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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool check = IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (check)
                {
                    FormMain formMain = new FormMain();
                    formMain.name = txtUsername.Text;
                    formMain.ShowDialog();
                    EmptyBox();

                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }

        public static bool IsValidNamePass(string name, string password)
        {
            bool flag;
            try
            {
                string str = string.Concat(new string[] { "SELECT Users_Name, Users_Password FROM Users WHERE Users_Name = '", name, "' AND Users_Password = '", password, "';" });
                SqlConnection connection = GetConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(str, connection));
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    flag = true;
                    return flag;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Username and password error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            flag = false;
            return flag;
        }

        private static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = CSMS; Integrated Security = True;");
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException )
            {
                MessageBox.Show("SQL connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return sqlConnection;
        }
    }
}
