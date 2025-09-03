using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public void Emptybox()
        {
            Count();
            report();
        }
        public void Count()
        {
            lblTotalProduct.Text = Count("SELECT COUNT(*) FROM PRODUCT;").ToString();
            lblTotalOrders.Text = Count("SELECT COUNT(*) FROM Orders WHERE Payment_Status = 'Not Paid';").ToString();
            lblLowStock.Text = Count("SELECT COUNT(*) FROM PRODUCT WHERE Product_Status = 'Not Available';").ToString();
            lblTotalRevenue.Text = Count("SELECT SUM(Grand_Total) FROM Orders;").ToString();
        }
        public void report()
        {

            DataTable data = GetDataFromOrdersTable1();

            chart.DataSource = data;

            chart.Series.Clear();
            chart.Series.Add("REVENUE");
            chart.Series["REVENUE"].XValueMember = "Orders_Date";
            chart.Series["REVENUE"].YValueMembers = "Grand_Total";
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart.DataBind();
        }


        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
            report();
        }

        public static int Count(string query)
        {
            int num;
            int num1 = 0;
            string str = query;
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection);
            try
            {
                num1 = (int)sqlCommand.ExecuteScalar();
                num = num1;
                return num;
            }
            catch (Exception)
            {
            }
            connection.Close();
            num = num1;
            return num;
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

        private DataTable GetDataFromOrdersTable1()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Orders_Date, Grand_Total FROM Orders;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(data);
            }
            return data;
        }


    }
}
