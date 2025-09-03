using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Shop_Management_System.PAL
{
    public partial class UserControlReport : UserControl
    {
        public UserControlReport()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcReport.SelectedTab = tpReport;
            lblGrandTotal.Text = "{?}";
            while (dgvReport.Rows.Count > 0)
            {
                dgvReport.Rows.RemoveAt(0);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            DataTable table = GetOrdersReport(startDate, endDate);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvReport.DataSource = table;
            int grandTotal = 0;
            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                int orderTotal;
                if (row.Cells[4].Value != null && int.TryParse(row.Cells[4].Value.ToString(), out orderTotal))
                {
                    grandTotal += orderTotal;
                }
            }
            lblGrandTotal.Text = grandTotal.ToString();
        }



        private DataTable GetOrdersReport(DateTime startDate, DateTime endDate)
        {
            SqlConnection connection = GetConnection();
            string str = "GetOrdersReport";
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@StartDate", startDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", endDate);
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

        private void btnGraph_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            DataTable data = GetDataFromOrdersTable(startDate, endDate);

            if (data.Rows.Count > 0)
            {
                chart.Series.Clear();
                chart.Series.Add("Revenue");
                chart.Series["Revenue"].XValueMember = "Orders_Date";
                chart.Series["Revenue"].YValueMembers = "Grand_Total";

                chart.DataSource = data;


                chart.ChartAreas[0].AxisX.Interval = 1; 
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; 

                chart.DataBind();
                tcReport.SelectedTab = tpGraph;
            }
            else
            {
                MessageBox.Show("No data available for the selected period.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void tpGraph_Enter(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                tcReport.SelectedTab = tpReport;
                MessageBox.Show("Please Genrate Report first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if(chart.Series.Count == 0)
            {
                tcReport.SelectedTab = tpReport;
                MessageBox.Show("Please Re Generate Graph.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tpGraph_Leave(object sender, EventArgs e)
        {
            chart.Series.Clear();
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

        private DataTable GetDataFromOrdersTable(DateTime startDate, DateTime endDate)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Orders_Date, Grand_Total FROM Orders WHERE Orders_Date BETWEEN @StartDate AND @EndDate;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                da.Fill(data);
            }
            return data;
        }


    }
}
