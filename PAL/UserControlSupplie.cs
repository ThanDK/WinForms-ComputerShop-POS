using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Computer_Shop_Management_System.PAL.UserControlBrand;
using static Computer_Shop_Management_System.PAL.UserControlOrder;

namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlSupplie : UserControl
    {
        private string Id = "";
        ImageConverter imageConverter;
        public UserControlSupplie()
        {
            InitializeComponent();
            imageConverter = new ImageConverter();
        }

        public void EmptyBox()
        {
            dtpSupplieDate.Value = DateTime.Now;
            txtSupplieName.Clear();
            txtSupplieAdress.Clear();
            txtSupplieProduct.Clear();
            cmbSupplieStatus.SelectedIndex = 0;
            nudSupplieQuantity.Value = 0;
            dgvSupplieList.Rows.Clear();
        }
        public void EmptyBox1()
        {
            dtpSupplieDate1.Value = DateTime.Now;
            picPhoto.Image = null;
            txtSupplieName1.Clear();
            txtSupplieAddress1.Clear();
            txtSupplieProduct1.Clear();
            cmbSupplieStatus1.SelectedIndex = 0;
            nudSupplieQuantity1.Value = 0;
            Id = "";
        }

        public void Reverse()
        {
            dtpSupplieDate1.Enabled = false;
            nudSupplieQuantity1.Enabled = false;
            txtSupplieAddress1.ReadOnly = true;
            txtSupplieName1.ReadOnly = true;
            txtSupplieProduct1.ReadOnly = true;
        }

        private void btnOrderSupplie_Click(object sender, EventArgs e)
        {
            if (txtSupplieName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter supplier name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSupplieAdress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter supplier address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSupplieProduct.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter supplier product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudSupplieQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to Order this supply?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvSupplieList.Rows.Add(
                    dtpSupplieDate.Value,               // Supplie_Date
                    txtSupplieName.Text.Trim(),         // Supplie_Name
                    txtSupplieProduct.Text.Trim(),      // Supplie_Product
                    txtSupplieAdress.Text.Trim(),       // Supplie_Adress
                    cmbSupplieStatus.SelectedItem,      // Supplie_Status
                    nudSupplieQuantity.Value            // Supplie_Quantity
                                            );
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSupplieList.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one supply.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvSupplieList.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    DateTime date = Convert.ToDateTime(row.Cells[0].Value);
                    string supplierName = row.Cells[1].Value.ToString();
                    string supplierProduct = row.Cells[2].Value.ToString();
                    string supplierAddress = row.Cells[3].Value.ToString();
                    string status = row.Cells[4].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[5].Value);


                    Supplie supplie = new Supplie(date, supplierName, supplierProduct, supplierAddress, status, quantity);
                    SaveSupplie(supplie);
                }
            }
            dgvSupplieList.Rows.Clear();
            MessageBox.Show("Supplies saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSummery_Click(object sender, EventArgs e)
        {
            Summary();
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 460, 600);
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, new Font("Segoe UI", 6, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }


        RichTextBox richTextBox = new RichTextBox();
        private void Summary()
        {
            richTextBox.Clear();
            richTextBox.Text += "===============================================================================================================================================\n";
            richTextBox.Text += "\t\t\t       COMPUTER SHOP SUMMARY SUPPLIE ORDER\n";
            richTextBox.Text += "===============================================================================================================================================\n";
            richTextBox.Text += "\t    Date\t\tName\t\tProduct\t\tAdress\t\tStatus\t\tQuantity\n";
            richTextBox.Text += "------------------------------------------------------------------------------------------------------------------------------------------------\n";

            foreach (DataGridViewRow row in dgvSupplieList.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int j = 0; j < dgvSupplieList.Columns.Count; j++)
                    {
                        richTextBox.Text += row.Cells[j].Value.ToString() + "    ||    ";
                    }
                    richTextBox.Text += "\n";
                }
            }

            richTextBox.Text += "----------------------------------------------------------------------------------------------------------------------------------------------------\n\n";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cmbSupplieStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please update status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please upload invoice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string status = cmbSupplieStatus1.SelectedItem.ToString();
                byte[] invoice = (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[]));
                int id = int.Parse(Id);
                ConfirmedSupplie(id, status, invoice);
                EmptyBox1();
                tcSupplie.SelectedTab = tpConfirmsupplie;
            }
        }

        private void tpConfirmsupplie_Enter(object sender, EventArgs e)
        {
            txtSearchSupplieName.Clear();
            dgvSupplie.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Supplie WHERE Supplie_Status = 'InWaiting';;", dgvSupplie);
            lblTotal.Text = dgvSupplie.Rows.Count.ToString();
        }

        private void tpReport_Enter(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, 12, 12);
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            dgvReportlist.Columns[0].Visible = false;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("First select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this order?", "Queastion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveSupplie(Id);
                    EmptyBox1();
                    tcSupplie.SelectedTab = tpConfirmsupplie;
                }
            }
        }

        private void txtSearchSupplieName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Supplie WHERE Supplie_Name LIKE '%" + txtSearchSupplieName.Text + "%' AND Supplie_Status = 'InWaiting';", dgvSupplie);
            lblTotal.Text = dgvSupplie.Rows.Count.ToString();
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void dgvSupplie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSupplie.Rows[e.RowIndex];
                string status = row.Cells[5].Value.ToString();

                if (status == "Confirmed")
                {
                    DialogResult result = MessageBox.Show("The order is already confirmed with an invoice.\n Do you want to re-upload the invoice?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                Id = row.Cells[0].Value.ToString();
                dtpSupplieDate1.Text = row.Cells[1].Value.ToString();
                txtSupplieName1.Text = row.Cells[2].Value.ToString();
                txtSupplieProduct1.Text = row.Cells[3].Value.ToString();
                txtSupplieAddress1.Text = row.Cells[4].Value.ToString();
                cmbSupplieStatus1.SelectedItem = status;
                nudSupplieQuantity1.Value = Convert.ToInt32(row.Cells[6].Value.ToString());


                if (row.Cells[7].Value != null && row.Cells[7].Value is byte[])
                {
                    byte[] imageData = (byte[])row.Cells[7].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picPhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPhoto.Image = null;
                }
                dtpSupplieDate1.Enabled = true;
                nudSupplieQuantity1.Enabled = true;
                txtSupplieAddress1.ReadOnly = false;
                txtSupplieName1.ReadOnly = false;
                txtSupplieProduct1.ReadOnly = false;
                tcSupplie.SelectedTab = tpOptions;
            }
        }

        private void dgvReportlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvReportlist.Rows[e.RowIndex];
                string status = row.Cells[5].Value.ToString();

                if (status == "Confirmed")
                {
                    DialogResult result = MessageBox.Show("The order is already confirmed with an invoice.\n Do you want to re-upload the invoice?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                Id = row.Cells[0].Value.ToString();
                dtpSupplieDate1.Text = row.Cells[1].Value.ToString();
                txtSupplieName1.Text = row.Cells[2].Value.ToString();
                txtSupplieProduct1.Text = row.Cells[3].Value.ToString();
                txtSupplieAddress1.Text = row.Cells[4].Value.ToString();
                cmbSupplieStatus1.SelectedItem = status;
                nudSupplieQuantity1.Value = Convert.ToInt32(row.Cells[6].Value.ToString());


                if (row.Cells[7].Value != null && row.Cells[7].Value is byte[])
                {
                    byte[] imageData = (byte[])row.Cells[7].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picPhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPhoto.Image = null;
                }

                tcSupplie.SelectedTab = tpOptions;
            }
        }


        private Form invoiceForm;
        private void dgvReportlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                object cellValue = dgvReportlist.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null && cellValue is byte[])
                {
                    byte[] imageData = (byte[])cellValue;
                    using (var ms = new MemoryStream(imageData))
                    {
                        if (invoiceForm == null || invoiceForm.IsDisposed)
                        {
                            invoiceForm = new Form();
                            invoiceForm.Text = "Invoice";
                            invoiceForm.StartPosition = FormStartPosition.CenterParent;

                            var pictureBox = new PictureBox();
                            pictureBox.Dock = DockStyle.Fill;
                            pictureBox.Image = Image.FromStream(ms);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                            invoiceForm.Controls.Add(pictureBox);
                        }
                        else // Reuse the existing form
                        {
                            var pictureBox = invoiceForm.Controls.OfType<PictureBox>().FirstOrDefault();
                            if (pictureBox != null)
                            {
                                pictureBox.Image = Image.FromStream(ms);
                            }
                        }

                        invoiceForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No invoice found yet. Please upload the invoice\n and confirm first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvSupplie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                object cellValue = dgvSupplie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null && cellValue is byte[])
                {
                    byte[] imageData = (byte[])cellValue;
                    using (var ms = new MemoryStream(imageData))
                    {
                        if (invoiceForm == null || invoiceForm.IsDisposed)
                        {
                            invoiceForm = new Form();
                            invoiceForm.Text = "Invoice";
                            invoiceForm.StartPosition = FormStartPosition.CenterParent;

                            var pictureBox = new PictureBox();
                            pictureBox.Dock = DockStyle.Fill;
                            pictureBox.Image = Image.FromStream(ms);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                            invoiceForm.Controls.Add(pictureBox);
                        }
                        else // Reuse the existing form
                        {
                            var pictureBox = invoiceForm.Controls.OfType<PictureBox>().FirstOrDefault();
                            if (pictureBox != null)
                            {
                                pictureBox.Image = Image.FromStream(ms);
                            }
                        }

                        invoiceForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No invoice found yet. Please upload the invoice\n and confirm first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (Id == "")
            {
                tcSupplie.SelectedTab = tpConfirmsupplie;
                MessageBox.Show("Double-click rows in Confirm Supplie to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
            Reverse();
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto);
        }


        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            DataTable table = GetSupplieReport(startDate, endDate);
            dgvReportlist.DataSource = table;
        }

        private void tpGraph_Enter(object sender, EventArgs e)
        {
            DataTable data = GetDataFromSuppliesTable();

            if (data.Rows.Count > 0 && data.Columns.Contains("Confirmed") && data.Columns.Contains("InWaiting"))
            {
                int countOfConfirmed = 0;
                int countOfInWaiting = 0;

                if (data.Rows[0]["Confirmed"] != DBNull.Value)
                    countOfConfirmed = Convert.ToInt32(data.Rows[0]["Confirmed"]);

                if (data.Rows[0]["InWaiting"] != DBNull.Value)
                    countOfInWaiting = Convert.ToInt32(data.Rows[0]["InWaiting"]);

                chart.Series["Status"].Points.Clear();

                DataPoint confirmedPoint = new DataPoint();
                confirmedPoint.SetValueY(countOfConfirmed);
                confirmedPoint.Color = Color.FromArgb(255, 128, 128);
                confirmedPoint.Label = "Confirmed: " + countOfConfirmed;
                confirmedPoint.Font = new Font("Arial", 12f);
                chart.Series["Status"].Points.Add(confirmedPoint);

                DataPoint inWaitingPoint = new DataPoint();
                inWaitingPoint.SetValueY(countOfInWaiting);
                inWaitingPoint.Color = Color.FromArgb(128, 128, 255);
                inWaitingPoint.Label = "In Waiting: " + countOfInWaiting;
                inWaitingPoint.Font = new Font("Arial", 12f);
                chart.Series["Status"].Points.Add(inWaitingPoint);

                chart.Series["Status"].ChartType = SeriesChartType.Pie;
            }
            else
            {
                MessageBox.Show("No data available to generate the graph.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private DataTable GetDataFromSuppliesTable()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT SUM(CASE WHEN Supplie_Status = 'Confirmed' THEN 1 ELSE 0 END) AS Confirmed, SUM(CASE WHEN Supplie_Status = 'InWaiting' THEN 1 ELSE 0 END) AS InWaiting FROM Supplie;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(data);
            }
            return data;
        }

        private void tpReport_Leave(object sender, EventArgs e)
        {
            while (dgvReportlist.Rows.Count > 0)
            {
                dgvReportlist.Rows.RemoveAt(0);
            }
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

        public static void ConfirmedSupplie(int id, string status, byte[] invoice)
        {
            string str = "UPDATE Supplie SET Supplie_Status = @Status, Supplie_Invoice = @Invoice WHERE Supplie_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;
            sqlCommand.Parameters.Add("@Invoice", SqlDbType.Image).Value = invoice;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Supply status and invoice updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to update supply status and invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void SaveSupplie(Supplie supplie)
        {
            string str = "INSERT INTO Supplie (Supplie_Date, Supplie_Name, Supplie_Product, Supplie_Adress, Supplie_Status, Supplie_Quantity) " +
                         "VALUES (@Date, @Name, @Product, @Address, @Status, @Quantity);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = supplie.SupplieDate;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = supplie.SupplieName;
            sqlCommand.Parameters.Add("@Product", SqlDbType.VarChar).Value = supplie.SupplieProduct;
            sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = supplie.SupplieAddress;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = supplie.SupplieStatus;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = supplie.SupplieQuantity;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Supplie not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        private void tpOrderSupplie_Leave(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private DataTable GetSupplieReport(DateTime startDate, DateTime endDate)
        {
            SqlConnection connection = GetConnection();
            string procedureName = "GetSupplieReport"; 
            SqlCommand sqlCommand = new SqlCommand(procedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@Start", startDate); 
            sqlCommand.Parameters.AddWithValue("@End", endDate);   
            DataTable table = new DataTable();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                table.Load(reader);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to return procedure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return table;
        }

        public static void RemoveSupplie(string Id)
        {
            string str = "DELETE FROM Supplie WHERE Supplie_Id = @Id";
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
                MessageBox.Show("Order not delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        public class Supplie
        {
            public DateTime SupplieDate { get; set; }
            public string SupplieName { get; set; }
            public string SupplieProduct { get; set; }
            public string SupplieAddress { get; set; }
            public string SupplieStatus { get; set; }
            public int SupplieQuantity { get; set; }


            public Supplie(DateTime date, string name, string product, string address, string status, int quantity)
            {
                SupplieDate = date;
                SupplieName = name;
                SupplieProduct = product;
                SupplieAddress = address;
                SupplieStatus = status;
                SupplieQuantity = quantity;
            }
        }




    }
}
