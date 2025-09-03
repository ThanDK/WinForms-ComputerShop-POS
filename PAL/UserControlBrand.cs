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
    public partial class UserControlBrand : UserControl
    {
        private string Id = "";

        public UserControlBrand()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            txtBrandName.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        private void EmptyBox1()
        {
            txtBrandName1.Clear();
            cmbStatus1.SelectedIndex = 0;
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Brand brand = new Brand(txtBrandName.Text.Trim(), cmbStatus.SelectedItem.ToString());
                AddBrand(brand);
                EmptyBox();
            }
        }

        private void tpAddBrand_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageBrand_Enter(object sender, EventArgs e)
        {
            txtSearchBrandName.Clear();
            dgvBrand.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Brand;", dgvBrand);
            lblTotal.Text = dgvBrand.Rows.Count.ToString();
        }

        private void txtSearchBrandName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Brand WHERE Brand_Name LIKE '%" + txtSearchBrandName.Text + "%';", dgvBrand);
            lblTotal.Text = dgvBrand.Rows.Count.ToString();
        }

        private void dgvBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvBrand.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtBrandName1.Text = row.Cells[1].Value.ToString();
                cmbStatus1.SelectedItem = row.Cells[2].Value.ToString();
                tcBrand.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("First Select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtBrandName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Brand brand = new Brand(txtBrandName1.Text.Trim(), cmbStatus1.SelectedItem.ToString());
                ChangeBrand(brand, Id);
                EmptyBox();
                tcBrand.SelectedTab = tpManageBrand;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("First Select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtBrandName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this brand?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveBrand(Id);
                    EmptyBox1();
                    tcBrand.SelectedTab = tpManageBrand;
                }
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (Id == "")
            {
                tcBrand.SelectedTab = tpManageBrand;
                MessageBox.Show("Double-click rows in Manage Brand to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void AddBrand(Brand brand)
        {
            string str = "INSERT INTO Brand VALUES (@Name, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = brand.Name;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = brand.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("Brand not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Brand already added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            connection.Close();
        }

        private void ChangeBrand(Brand brand, string id)
        {
            string str = "UPDATE Brand SET Brand_Name = @Name, Brand_Status = @Status WHERE Brand_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = brand.Name;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = brand.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException)
            {
                MessageBox.Show("Brand not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private void UpdateProductQuantity(string productName, int newQuantity)
        {
            string updateQuery = "UPDATE Product SET Product_Quantity = @Quantity WHERE Product_Name = @Name;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(updateQuery, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = productName;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = newQuantity;
            try
            {
                sqlCommand.ExecuteNonQuery();               
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update product quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             connection.Close();
        }

        private void RemoveBrand(string Id)
        {
            string str = "DELETE FROM Brand WHERE Brand_Id = @Id";
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
                MessageBox.Show("Brand not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private void DisplayAndSearch(string query, DataGridView dgv)
        {
            SqlConnection connection = GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(query, connection));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
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

        public class Brand
        {
            public string Name { get; set; }
            public string Status { get; set; }

            public Brand(string name, string status)
            {
                Name = name;
                Status = status;
            }
        }
    }
}
