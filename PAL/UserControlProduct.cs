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
    public partial class UserControlProduct : UserControl
    {
        private string id = "";
        byte[] image;
        ImageConverter imageConverter;
        MemoryStream memoryStream;

        public UserControlProduct()
        {
            InitializeComponent();
            imageConverter = new ImageConverter();
        }

        private void ImageUpload(PictureBox picture)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    picture.Image = Image.FromFile(openFileDialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Image upload error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EmptyBox()
        {
            txtProductName.Clear();
            picPhoto.Image = null;
            nudRate.Value = 0;
            nudQuantity.Value = 0;
            cmbBrand.Items.Clear();
            cmbBrand.Items.Add("--SELECT--");
            BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrand);
            cmbBrand.SelectedIndex = 0;
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--SELECT--");
            BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategory);
            cmbCategory.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        public void EmptyBox1()
        {
            txtProductName1.Clear();
            picPhoto1.Image = null;
            nudRate1.Value = 0;
            nudQuantity1.Value = 0;
            ComboBoxAutoFill();
            cmbStatus1.SelectedIndex = 0;
            id = "";
        }

        private void ComboBoxAutoFill()
        {
            cmbBrand1.Items.Clear();
            cmbBrand1.Items.Add("--SELECT--");
            BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrand1);
            cmbBrand1.SelectedIndex = 0;
            cmbCategory1.Items.Clear();
            cmbCategory1.Items.Add("--SELECT--");
            BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategory1);
            cmbCategory1.SelectedIndex = 0;
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto);
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please select image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudRate.Value == 0)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrand.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtProductName.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[])), Convert.ToInt32(nudRate.Value), Convert.ToInt32(nudQuantity.Value), cmbBrand.SelectedItem.ToString(), cmbCategory.SelectedItem.ToString(), cmbStatus.SelectedItem.ToString());
                AddProduct(product);
                EmptyBox();
            }
        }

        private void tpAddProduct_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageProduct_Enter(object sender, EventArgs e)
        {
            txtSearchProductName.Clear();
            dgvProduct.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Product;", dgvProduct);
            lblTotal.Text = dgvProduct.Rows.Count.ToString();
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Product WHERE Product_Name LIKE '%" + txtSearchProductName.Text + "%';", dgvProduct);
            lblTotal.Text = dgvProduct.Rows.Count.ToString();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ComboBoxAutoFill();
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtProductName1.Text = row.Cells[1].Value.ToString();
                image = (byte[])row.Cells[2].Value;
                memoryStream = new MemoryStream(image);
                picPhoto1.Image = Image.FromStream(memoryStream);
                nudRate1.Value = Convert.ToInt32(row.Cells[3].Value.ToString());
                nudQuantity1.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
                cmbBrand1.SelectedItem = row.Cells[5].Value.ToString();
                cmbCategory1.SelectedItem = row.Cells[6].Value.ToString();
                cmbStatus1.SelectedItem = row.Cells[7].Value.ToString();
                tcProduct.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtProductName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto1.Image == null)
            {
                MessageBox.Show("Please select image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudRate1.Value == 0)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuantity1.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrand1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategory1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtProductName1.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto1.Image, typeof(byte[])), Convert.ToInt32(nudRate1.Value), Convert.ToInt32(nudQuantity1.Value), cmbBrand1.SelectedItem.ToString(), cmbCategory1.SelectedItem.ToString(), cmbStatus1.SelectedItem.ToString());
                ChangeProduct(product, id);
                EmptyBox1();
                tcProduct.SelectedTab = tpManageProduct;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtProductName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto1.Image == null)
            {
                MessageBox.Show("Please select image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudRate1.Value == 0)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuantity1.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrand1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategory1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this product?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveProduct(id);
                    EmptyBox1();
                    tcProduct.SelectedTab = tpManageProduct;
                }
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (id == "")
            {
                tcProduct.SelectedTab = tpManageProduct;
                MessageBox.Show("Double-click rows in Manage Product to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
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

        public static void RemoveProduct(string Id)
        {
            string str = "DELETE FROM Product WHERE Product_Id = @Id";
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
                MessageBox.Show("Product not delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        public static void BrandCategoryProduct(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlDataReader sqlDataReader = (new SqlCommand(query, connection)).ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0]);
            }
            connection.Close();
        }

        public static void ChangeProduct(Product product, string id)
        {
            string str = "UPDATE Product SET Product_Name = @Name, Product_Image = @Image, Product_Rate = @Rate, Product_Quantity = @Quantity, Product_Brand = @Brand, Product_Category = @Category, Product_Status = @Status WHERE Product_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
            sqlCommand.Parameters.Add("@Image", SqlDbType.Image).Value = product.Image;
            sqlCommand.Parameters.Add("@Rate", SqlDbType.Int).Value = product.Rate;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
            sqlCommand.Parameters.Add("@Brand", SqlDbType.VarChar).Value = product.Brand;
            sqlCommand.Parameters.Add("@Category", SqlDbType.VarChar).Value = product.Category;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = product.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Format("Product not change.\n{0}", sqlException), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        public static void AddProduct(Product product)
        {
            string str = "INSERT INTO Product VALUES (@Name, @Image, @Rate, @Quantity, @Brand, @Category, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
            sqlCommand.Parameters.Add("@Image", SqlDbType.Image).Value = product.Image;
            sqlCommand.Parameters.Add("@Rate", SqlDbType.Int).Value = product.Rate;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
            sqlCommand.Parameters.Add("@Brand", SqlDbType.VarChar).Value = product.Brand;
            sqlCommand.Parameters.Add("@Category", SqlDbType.VarChar).Value = product.Category;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = product.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("Product not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Product already add.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            connection.Close();
        }

        public class Product
        {
            public string Name { get; set; }
            public byte[] Image { get; set; }
            public int Rate { get; set; }
            public int Quantity { get; set; }
            public string Brand { get; set; }
            public string Category { get; set; }
            public string Status { get; set; }

            public Product(string name, byte[] image, int rate, int quantity, string brand, string category, string status)
            {
                Name = name;
                Image = image;
                Rate = rate;
                Quantity = quantity;
                Brand = brand;
                Category = category;
                Status = status;
            }
        }
    }
}
