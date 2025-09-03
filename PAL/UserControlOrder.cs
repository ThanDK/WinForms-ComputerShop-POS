using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlOrder : UserControl
    {
        private string id = " ";
        public UserControlOrder()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            dtpDate.Value = DateTime.Now;
            txtCustomerName.Clear();
            mtbCustomerNumber.Clear();
            AddClear();
            AddClear1();
            dgvProductList.Rows.Clear();
            txtTotalAmount.Text = "0";
            nudPaidAmount.Value = 0;
            txtDueAmount.Text = "0";
            nudDiscount.Value = 0;
            txtGrandTotal.Text = "0";
            cbAlreadyMember.Checked = false;
            cmbPaymentStatus.SelectedIndex = 0;
        }

        private void AddClear()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("--SELECT--");
            BrandCategoryProduct("SELECT Product_Name From Product WHERE Product_Status = 'Available' ORDER BY Product_Name;", cmbProduct);
            cmbProduct.SelectedIndex = 0;
            txtRate.Clear();
            nudQuantity.Value = 0;
            txtTotal.Clear();
        }
        private void AddClear1()
        {
            cmbCustomerName.Items.Clear();
            cmbCustomerName.Items.Add("--SELECT MEMBER--");
            MemberCategory("SELECT Members_Name From Members ORDER BY Members_Name;", cmbCustomerName);
            cmbCustomerName.SelectedIndex = 0;
        }
        private void EmptyBox1()
        {
            dtpDate1.Value = DateTime.Now;
            txtCustomerName1.Clear();
            mtbCustomerNumber1.Clear();
            txtTotalAmount1.Text = "0";
            nudPaidAmount1.Value = 0;
            txtDueAmount1.Text = "0";
            nudDiscount1.Value = 0;
            txtGrandTotal1.Text = "0";
            cmbPaymentStatus1.SelectedIndex = 0;
            cbAlreadyMember.Checked = false;
            id = "";
        }
        private void cbAlreadyMember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlreadyMember.Checked)
            {
                mtbCustomerNumber.Clear();
                txtCustomerName.Clear();
                lblDiscount.Visible = true;
                nudDiscount.Visible = true;
                cmbCustomerName.Visible = true;
                txtCustomerName.Visible = false;
                mtbCustomerNumber.ReadOnly = true;
            }
            else
            {
                EmptyBox();
                lblDiscount.Visible = false;
                nudDiscount.Visible = false; 
                cmbCustomerName.Visible = false;
                txtCustomerName.Visible = true;
                mtbCustomerNumber.ReadOnly = false;

            }
        }


        RichTextBox richTextBox = new RichTextBox();

        private void Receipt()
        {
            richTextBox.Clear();
            richTextBox.Text += "-------------------------------------------------------------------------------\n";
            richTextBox.Text += "\t       COMPUTER SHOP SUMMARY RECEIPT\n";
            richTextBox.Text += "-------------------------------------------------------------------------------\n";
            richTextBox.Text += "   Date: " + dtpDate.Value.ToShortDateString() + "\n";
            richTextBox.Text += "   Name: " + txtCustomerName.Text.Trim() + "\n";
            richTextBox.Text += "   Number: " + mtbCustomerNumber.Text.Trim() + "\n\n";
            richTextBox.Text += "-------------------------------------------------------------------------------\n";
            richTextBox.Text += "   Name\t\tRate\t\tQuantity\t\tTotal\n";
            richTextBox.Text += "-------------------------------------------------------------------------------\n";

            for (int i = 0; i < dgvProductList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProductList.Columns.Count - 1; j++)
                    richTextBox.Text += dgvProductList.Rows[i].Cells[j].Value.ToString() + "     ||     ";
                richTextBox.Text += "\n";
            }

            richTextBox.Text += "-------------------------------------------------------------------------------\n\n";
            richTextBox.Text += "\t\t\t\t\tTotal: $ " + txtTotalAmount.Text + "\n";
            richTextBox.Text += "\t\t\t\t\tPaid Amount: $ " + nudPaidAmount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tDue Amount: $ " + txtDueAmount.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\tDiscount: $ " + nudDiscount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tSummary Total: $ " + txtGrandTotal.Text + "\n";
        }


        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Add");
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(picSearch, "Search");
        }

        int oTotal = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (nudQuantity.Value > 0)
                {
                    int rate, total;
                    Int32.TryParse(txtRate.Text, out rate);
                    Int32.TryParse(txtTotal.Text, out total); 

                    bool productFound = false;

                    if (dgvProductList.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow rows in dgvProductList.Rows)
                        {
                            if (rows.Cells[0].Value.ToString() == cmbProduct.SelectedItem.ToString())
                            {
                                int quantity = Convert.ToInt32(rows.Cells[2].Value.ToString());
                                int total1 = Convert.ToInt32(rows.Cells[3].Value.ToString());
                                quantity += Convert.ToInt32(nudQuantity.Value);
                                total1 += total;
                                rows.Cells[2].Value = quantity;
                                rows.Cells[3].Value = total1;
                                productFound = true;
                                AddClear();
                                break; 
                            }
                        }
                    }

                    if (!productFound && cmbProduct.SelectedIndex != 0)
                    {
                        txtTotal.Text = (rate * Convert.ToInt32(nudQuantity.Value)).ToString();
                        string[] row =
                        {
                            cmbProduct.SelectedItem.ToString(), txtRate.Text, nudQuantity.Value.ToString(), txtTotal.Text
                        };
                        dgvProductList.Rows.Add(row);
                        AddClear();
                    }
                }

                int totalAmount = 0;
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    totalAmount += Convert.ToInt32(row.Cells[3].Value);
                }
                txtTotalAmount.Text = totalAmount.ToString();
            }
        }



        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rate = Rate(cmbProduct.SelectedItem.ToString());
            if (rate != string.Empty)
                txtRate.Text = rate;
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string member = Member(cmbCustomerName.SelectedItem.ToString());
            if (member != string.Empty)
                mtbCustomerNumber.Text = member;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            int rate;
            Int32.TryParse(txtRate.Text, out rate);
            txtTotal.Text = (rate * Convert.ToInt32(nudQuantity.Value)).ToString();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int rowIndex = dgvProductList.CurrentCell.RowIndex;
                dgvProductList.Rows.RemoveAt(rowIndex);
                if (dgvProductList.Rows.Count != 0)
                {
                    foreach (DataGridViewRow rows in dgvProductList.Rows)
                    {
                        oTotal += Convert.ToInt32(rows.Cells[3].Value.ToString());
                        txtTotalAmount.Text = oTotal.ToString();
                    }
                }
                else
                    txtTotalAmount.Text = "0";
                oTotal = 0;

            }
        }

        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            txtDueAmount.Text = (Convert.ToInt32(nudPaidAmount.Value) - Convert.ToInt32(txtTotalAmount.Text)).ToString();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            txtGrandTotal.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(nudDiscount.Value)).ToString();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            nudPaidAmount_ValueChanged(sender, e);
            nudDiscount_ValueChanged(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbAlreadyMember.Checked)
            {
                if (cmbCustomerName.SelectedIndex == 0) 
                {
                    MessageBox.Show("Please select member name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return;
                }
                else if (nudPaidAmount.Value == 0)
                {
                    MessageBox.Show("Please enter paid amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cmbPaymentStatus.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select payment status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (dgvProductList.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the product list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (nudDiscount.Value == 0)
                {
                    MessageBox.Show("Please enter discount for member.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                    bool allQuantitiesSufficient = true;

                    foreach (DataGridViewRow row in dgvProductList.Rows)
                    {
                        string productName = row.Cells[0].Value.ToString();
                        int orderedQuantity = Convert.ToInt32(row.Cells[2].Value);
                        int currentQuantity = ProductQuantity(productName);

                        if (currentQuantity == 0 || currentQuantity < orderedQuantity)
                        {
                            MessageBox.Show($"The current quantity of {productName} is insufficient. Order cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            allQuantitiesSufficient = false;
                            break;
                        }
                        else
                        {
                            int newQuantity = currentQuantity - orderedQuantity;
                            UpdateProductQuantity(productName, newQuantity);
                        }
                    }
                    if (allQuantitiesSufficient)
                    {
                        txtCustomerName.Text = cmbCustomerName.Text;
                        Order order = new Order(dtpDate.Value.Date, txtCustomerName.Text.Trim(), mtbCustomerNumber.Text, Convert.ToInt32(txtTotalAmount.Text), Convert.ToInt32(nudPaidAmount.Value), Convert.ToInt32(txtDueAmount.Text), Convert.ToInt32(nudDiscount.Value), Convert.ToInt32(txtGrandTotal.Text), cmbPaymentStatus.SelectedItem.ToString());
                        SaveOrder(order);
                        EmptyBox();
                    }
                }
            }

            else
            {
                if (txtCustomerName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!mtbCustomerNumber.MaskCompleted)
                {
                    MessageBox.Show("Please enter valid customer number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (nudPaidAmount.Value == 0)
                {
                    MessageBox.Show("Please enter paid amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cmbPaymentStatus.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select payment status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (dgvProductList.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the product list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                    bool allQuantitiesSufficient = true;

                    foreach (DataGridViewRow row in dgvProductList.Rows)
                    {
                        string productName = row.Cells[0].Value.ToString();
                        int orderedQuantity = Convert.ToInt32(row.Cells[2].Value);
                        int currentQuantity = ProductQuantity(productName);

                        if (currentQuantity == 0 || currentQuantity < orderedQuantity)
                        {
                            MessageBox.Show($"The current quantity of {productName} is insufficient. Order cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            allQuantitiesSufficient = false;
                            break;
                        }
                        else
                        {
                            int newQuantity = currentQuantity - orderedQuantity;
                            UpdateProductQuantity(productName, newQuantity);
                        }
                    }

                   
                    if (allQuantitiesSufficient)
                    {
                        Order order = new Order(dtpDate.Value.Date, txtCustomerName.Text.Trim(), mtbCustomerNumber.Text, Convert.ToInt32(txtTotalAmount.Text), Convert.ToInt32(nudPaidAmount.Value), Convert.ToInt32(txtDueAmount.Text), Convert.ToInt32(nudDiscount.Value), Convert.ToInt32(txtGrandTotal.Text), cmbPaymentStatus.SelectedItem.ToString());
                        SaveOrder(order);
                        EmptyBox();
                    }
                }
            }
        }



        private void btnReceipt_Click(object sender, EventArgs e)
        {
            Receipt();
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, new Font("Segoe UI", 6, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            nudQuantity_ValueChanged(sender, e)
;
        }

        private void tpManageOrders_Enter(object sender, EventArgs e)
        {
            txtSearchCustomerName.Clear();
            dgvOrders.Columns[0].Visible = false;
            DisplayAndSearch("SELECT * FROM Orders;", dgvOrders);
            lblTotal.Text = dgvOrders.Rows.Count.ToString();
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Orders WHERE Customer_Name LIKE '%" + txtSearchCustomerName.Text + "%';", dgvOrders);
            lblTotal.Text = dgvOrders.Rows.Count.ToString();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                dtpDate1.Text = row.Cells[1].Value.ToString();
                txtCustomerName1.Text = row.Cells[2].Value.ToString();
                mtbCustomerNumber1.Text = row.Cells[3].Value.ToString();
                txtTotalAmount1.Text = row.Cells[4].Value.ToString();
                nudPaidAmount1.Value = Convert.ToInt32(row.Cells[5].Value.ToString());
                txtDueAmount1.Text = row.Cells[6].Value.ToString();
                nudDiscount1.Value = Convert.ToInt32(row.Cells[7].Value.ToString());
                txtGrandTotal1.Text = row.Cells[8].Value.ToString();
                cmbPaymentStatus1.SelectedItem = row.Cells[9].Value.ToString();
                tcOrder.SelectedTab = tpOptions;
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (id == " ")
            {
                tcOrder.SelectedTab = tpManageOrders;
                MessageBox.Show("Double-click rows in Manage Orders to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("First select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCustomerName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!mtbCustomerNumber1.MaskCompleted)
            {
                MessageBox.Show("Please enter vaild customer number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudPaidAmount1.Value == 0)
            {
                MessageBox.Show("Please enter paid amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbPaymentStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Order order = new Order(dtpDate1.Value.Date, txtCustomerName1.Text.Trim(), mtbCustomerNumber1.Text, Convert.ToInt32(txtTotalAmount1.Text), Convert.ToInt32(nudPaidAmount1.Value), Convert.ToInt32(txtDueAmount1.Text), Convert.ToInt32(nudDiscount1.Value), Convert.ToInt32(txtGrandTotal1.Text), cmbPaymentStatus1.SelectedItem.ToString());
                ChangeOrder(order, id);
                EmptyBox1();
                tcOrder.SelectedTab = tpManageOrders;

            }
        }

        private void tcOrder_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void nudPaidAmount1_ValueChanged(object sender, EventArgs e)
        {
            txtDueAmount1.Text = (Convert.ToInt32(nudPaidAmount1.Value) - Convert.ToInt32(txtTotalAmount1.Text)).ToString();
        }

        private void nudDiscount1_ValueChanged(object sender, EventArgs e)
        {
            txtGrandTotal1.Text = (Convert.ToInt32(txtTotalAmount1.Text) - Convert.ToInt32(nudDiscount1.Value)).ToString();
        }

        private void txtTotalAmount1_TextChanged(object sender, EventArgs e)
        {
            nudPaidAmount1_ValueChanged(sender, e);
            nudDiscount1_ValueChanged(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("First select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCustomerName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!mtbCustomerNumber1.MaskCompleted)
            {
                MessageBox.Show("Please enter vaild customer number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudPaidAmount1.Value == 0)
            {
                MessageBox.Show("Please enter paid amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbPaymentStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this order?", "Queastion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveOrder(id);
                    EmptyBox1();
                    tcOrder.SelectedTab = tpManageOrders;
                }

            }
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

        public static void SaveOrder(Order order)
        {
            string str = "INSERT INTO Orders VALUES (@Date, @Name, @Number, @TotalAmount, @PaidAmount, @DueAmount, @Discount, @GrandTotal, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Date", SqlDbType.VarChar).Value = order.Date;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = order.Name;
            sqlCommand.Parameters.Add("@Number", SqlDbType.VarChar).Value = order.Number;
            sqlCommand.Parameters.Add("@TotalAmount", SqlDbType.Int).Value = order.TotalAmount;
            sqlCommand.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = order.PaidAmount;
            sqlCommand.Parameters.Add("@DueAmount", SqlDbType.Int).Value = order.DueAmount;
            sqlCommand.Parameters.Add("@Discount", SqlDbType.Int).Value = order.Discount;
            sqlCommand.Parameters.Add("@GrandTotal", SqlDbType.Int).Value = order.GrandTotal;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = order.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("Order not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("An order with the same number already exists. Please enter a unique order number.", "Order Number Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            connection.Close();
        }

        public static void ChangeOrder(Order order, string id)
        {
            string str = "UPDATE Orders SET Orders_Date = @Date, Customer_Name = @Name, Customer_Number = @Number, Total_Amount = @TotalAmount, Paid_Amount = @PaidAmount, Due_Amount = @DueAmount, Discount = @Discount,  Grand_Total = @GrandTotal, Payment_Status = @Status WHERE Orders_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@Date", SqlDbType.VarChar).Value = order.Date;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = order.Name;
            sqlCommand.Parameters.Add("@Number", SqlDbType.VarChar).Value = order.Number;
            sqlCommand.Parameters.Add("@TotalAmount", SqlDbType.Int).Value = order.TotalAmount;
            sqlCommand.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = order.PaidAmount;
            sqlCommand.Parameters.Add("@DueAmount", SqlDbType.Int).Value = order.DueAmount;
            sqlCommand.Parameters.Add("@Discount", SqlDbType.Int).Value = order.Discount;
            sqlCommand.Parameters.Add("@GrandTotal", SqlDbType.Int).Value = order.GrandTotal;
            sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = order.Status;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Change successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show("Order not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Order already add.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            connection.Close();
        }

        public static void RemoveOrder(string Id)
        {
            string str = "DELETE FROM Orders WHERE Orders_Id = @Id";
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

        public static void MemberCategory(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlDataReader sqlDataReader = (new SqlCommand(query, connection)).ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0]);
            }
            connection.Close();
        }

        public static string Rate(string name)
        {
            string str = "";
            string str1 = "SELECT Product_Rate FROM Product WHERE Product_Name = @Name;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str1, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                str = sqlDataReader["Product_Rate"].ToString();
            }
            connection.Close();
            return str;
        }

        public static string Member(string name)
        {
            string str = "";
            string str1 = "SELECT Members_Number FROM Members WHERE Members_Name = @Name;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str1, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                str = sqlDataReader["Members_Number"].ToString();
            }
            connection.Close();
            return str;
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
                if (newQuantity == 0)
                {
                    string updateStatusQuery = "UPDATE Product SET Product_Status = 'Not Available' WHERE Product_Name = @Name;";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection);
                    updateStatusCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = productName;
                    updateStatusCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update product quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int ProductQuantity(string name)
        {
            int quantity = 0;
            string queryString = "SELECT Product_Quantity FROM Product WHERE Product_Name = @Name;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(queryString, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                quantity = Convert.ToInt32(sqlDataReader["Product_Quantity"]);
            }
            connection.Close();
            return quantity;
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

        public class Order
        {
            public DateTime Date { get; set; }
            public int Discount { get; set; }
            public int DueAmount { get; set; }
            public int GrandTotal { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public int PaidAmount { get; set; }
            public string Status { get; set; }
            public int TotalAmount { get; set; }

            public Order(DateTime date, string name, string number, int totalAmount, int paidAmount, int dueAmount, int discount, int grandTotal, string status)
            {
                Date = date;
                Name = name;
                Number = number;
                TotalAmount = totalAmount;
                PaidAmount = paidAmount;
                DueAmount = dueAmount;
                Discount = discount;
                GrandTotal = grandTotal;
                Status = status;
            }
        }








    }
}
