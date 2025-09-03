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
using static Computer_Shop_Management_System.PAL.UserControlBrand;



namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlCategory : UserControl
    {
        private string id = "";

        public UserControlCategory()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            txtCategoryName.Clear();
            cmbStatus.SelectedIndex = 0;
        }
        public void EmptyBox1()
        {
            txtCategoryName1.Clear();
            cmbStatus1.SelectedIndex = 0;
            id = "";
        }
        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter category name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Category category = new Category(txtCategoryName.Text.Trim(), cmbStatus.SelectedItem.ToString());
                AddCategory(category);
                EmptyBox();
            }
        }

        private void tpAddCategory_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageCategory_Enter(object sender, EventArgs e)
        {
            txtSearchCategoryName.Clear();
            dgvCategory.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Category;", dgvCategory);
            lblTotal.Text = dgvCategory.Rows.Count.ToString();
        }

        private void txtSearchCategoryName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * From Category WHERE Category_name LIKE '%" + txtSearchCategoryName.Text + "%';", dgvCategory);
            lblTotal.Text = dgvCategory.Rows.Count.ToString();
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtCategoryName1.Text = row.Cells[1].Value.ToString();
                cmbStatus1.SelectedItem = row.Cells[2].Value.ToString();
                tcCategory.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCategoryName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter category name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Category category = new Category(txtCategoryName1.Text.Trim(), cmbStatus1.SelectedItem.ToString());
                ChangeCategory(category, id);
                EmptyBox1();
                tcCategory.SelectedTab = tpManageCategory;
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCategoryName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter category name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this category?", "Queastion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveCategory(id);
                    EmptyBox1();
                    tcCategory.SelectedTab = tpManageCategory;
                }
            }
        }
        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (id == "")
            {
                tcCategory.SelectedTab = tpManageCategory;
                MessageBox.Show("Double-click rows in Manage Category to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void AddCategory(Category category)
        {
            string str = "INSERT INTO Category VALUES (@Name, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = category.Name;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = category.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("Category not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Category already added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            connection.Close();
        }

        private void DisplayAndSearch(string query, DataGridView dgv)
        {
            string str = query;
            SqlConnection connection = GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(str, connection));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            connection.Close();
        }

        private void ChangeCategory(Category category, string id)
        {
            string str = "UPDATE Category SET Category_Name = @Name, Category_Status = @Status WHERE Category_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = category.Name;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = category.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException)
            {
                MessageBox.Show("Category not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private void RemoveCategory(string Id)
        {
            string str = "DELETE FROM Category WHERE Category_Id = @Id";
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
                MessageBox.Show("Category not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private SqlConnection GetConnection()
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

        public class Category
        {
            public string Name { get; set; }
            public string Status { get; set; }

            public Category(string name, string status)
            {
                Name = name;
                Status = status;
            }
        }
    }
}
