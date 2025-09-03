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

namespace Computer_Shop_Management_System.PAL
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string pass = ForgotPassword(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                if (pass != string.Empty)
                {
                    MessageBox.Show($"Your password is: {pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($"Username or Email is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string ForgotPassword(string name, string email)
        {
            string str = "";
            string str1 = "SELECT Users_Password FROM Users WHERE Users_Name = @Name AND Users_Email = @Email;";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str1, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                str = sqlDataReader["Users_Password"].ToString();
            }
            connection.Close();
            return str;
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
    }
}