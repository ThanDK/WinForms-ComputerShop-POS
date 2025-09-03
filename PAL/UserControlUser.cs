using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlUser : UserControl
    {
        private string id = "";

        public UserControlUser()
        {
            InitializeComponent();
        }
        public void EmptyBox()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }
        public void EmptyBox1()
        {
            txtUserName1.Clear();
            txtEmail1.Clear();
            txtPassword1.Clear();
            id = "";
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (id == "")
            { 
                tcUser.SelectedTab = tpManageUsers;
                MessageBox.Show("Double-click rows in Manage Users to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }


        private void tpAddUser_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUserName.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());
                AddUser(user);
                EmptyBox();
            }
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUserName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter User name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUserName1.Text.Trim(), txtEmail1.Text.Trim(), txtPassword1.Text.Trim());
                ChangeUser(user, id);
                EmptyBox1();
                tcUser.SelectedTab = tpManageUsers;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUserName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter User name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this brand?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveUser(id);
                    EmptyBox1();
                    tcUser.SelectedTab = tpManageUsers;
                }
            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtUserName1.Text = row.Cells[1].Value.ToString();
                txtEmail1.Text = row.Cells[2].Value.ToString();
                txtPassword1.Text = row.Cells[3].Value.ToString();
                tcUser.SelectedTab = tpOptions;
            }
        }

        private void txtSearchUserName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Users WHERE Users_Name LIKE '%" + txtSearchUserName.Text + "%';", dgvUser);
            lblTotal.Text = dgvUser.Rows.Count.ToString();
        }

        private void tpManageUsers_Enter(object sender, EventArgs e)
        {
            txtSearchUserName.Clear();
            dgvUser.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Users;", dgvUser);
            lblTotal.Text = dgvUser.Rows.Count.ToString();
        }

        public static void RemoveUser(string Id)
        {
            string str = "DELETE FROM Users WHERE Users_Id = @Id";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException)
            {
                MessageBox.Show("User not delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        public static void ChangeUser(User user, string id)
        {
            string str = "UPDATE Users SET Users_Name = @Name, Users_Email = @Email, Users_Password = @Password WHERE Users_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Name;
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException)
            {
                MessageBox.Show("User not change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = CSMS; Integrated Security = True;");
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("SQL connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return sqlConnection;
        }

        public static void AddUser(User user)
        {
            string str = "INSERT INTO Users VALUES (@Name, @Email, @Password);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Name;
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("User not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("User already add.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            connection.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string str = query;
            SqlConnection connection = GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(str, connection));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            connection.Close();
        }

        public class User
        {
            public string Email { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }

            public User(string name, string email, string password)
            {
                Name = name;
                Email = email;
                Password = password;
            }
        }


    }
}
