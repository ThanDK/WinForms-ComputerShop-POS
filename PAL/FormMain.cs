using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.PAL
{
    public partial class FormMain : Form
    {
        public string name = "{?}";

        public FormMain()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            timerDateAndTime.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MovePanel(btnClose);
                timerDateAndTime.Stop();
                Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlDashboard1.Emptybox();
            userControlDashboard1.Visible = true;
        }
       private void btnSuplie_Click(object sender, EventArgs e)
        {
            MovePanel(btnSuplie);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlProduct1.Visible = false;
            userControlCategory1.Visible = false;
            userControlOrder1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlSupplie1.EmptyBox();
            userControlSupplie1.Visible = true;

        }
        private void btnBrand_Click(object sender, EventArgs e)
        {
            MovePanel(btnBrand);
            userControlDashboard1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlBrand1.EmptyBox();
            userControlBrand1.Visible = true;

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MovePanel(btnCategory);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlCategory1.EmptyBox();
            userControlCategory1.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MovePanel(btnProduct);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlProduct1.EmptyBox();
            userControlProduct1.Visible = true;

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MovePanel(btnOrders);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlOrder1.EmptyBox();
            userControlOrder1.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnReport);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.Visible = false;
            userControlReport1.EmptyBox();
            userControlReport1.Visible = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MovePanel(btnUsers);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlMember1.Visible = false;
            userControlUser1.EmptyBox();
            userControlUser1.Visible = true;
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            MovePanel(btnMember);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrder1.Visible = false;
            userControlSupplie1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlMember1.EmptyBox();
            userControlMember1.Visible = true;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }


    }
}
