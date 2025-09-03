namespace Computer_Shop_Management_System.PAL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSuplie = new System.Windows.Forms.Button();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.userControlMember1 = new Computer_Shop_Management_System.PAL.UserControlMember();
            this.userControlDashboard1 = new Computer_Shop_Management_System.PAL.UserControlDashboard();
            this.userControlCategory1 = new Computer_Shop_Management_System.PAL.UserControlCategory();
            this.userControlBrand1 = new Computer_Shop_Management_System.PAL.UserControlBrand();
            this.userControlReport1 = new Computer_Shop_Management_System.PAL.UserControlReport();
            this.userControlUser1 = new Computer_Shop_Management_System.PAL.UserControlUser();
            this.userControlSupplie1 = new Computer_Shop_Management_System.PAL.UserControlSupplie();
            this.userControlOrder1 = new Computer_Shop_Management_System.PAL.UserControlOrder();
            this.userControlProduct1 = new Computer_Shop_Management_System.PAL.UserControlProduct();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnSuplie);
            this.panel1.Controls.Add(this.pnlMove);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 750);
            this.panel1.TabIndex = 0;
            // 
            // btnMember
            // 
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Image = global::Computer_Shop_Management_System.Properties.Resources.Member;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(20, 520);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(200, 38);
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "         Member";
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSuplie
            // 
            this.btnSuplie.FlatAppearance.BorderSize = 0;
            this.btnSuplie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplie.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnSuplie.ForeColor = System.Drawing.Color.White;
            this.btnSuplie.Image = global::Computer_Shop_Management_System.Properties.Resources.Supply_Chain;
            this.btnSuplie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuplie.Location = new System.Drawing.Point(20, 212);
            this.btnSuplie.Name = "btnSuplie";
            this.btnSuplie.Size = new System.Drawing.Size(200, 38);
            this.btnSuplie.TabIndex = 1;
            this.btnSuplie.Text = "         Supplie";
            this.btnSuplie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuplie.UseVisualStyleBackColor = true;
            this.btnSuplie.Click += new System.EventHandler(this.btnSuplie_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(12, 168);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(6, 38);
            this.pnlMove.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Computer_Shop_Management_System.Properties.Resources.Logout;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(20, 707);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "         Log Out";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Computer_Shop_Management_System.Properties.Resources.User;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(20, 476);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 38);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "         Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Computer_Shop_Management_System.Properties.Resources.Graph_Report_Script;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(20, 432);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 38);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "         Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = global::Computer_Shop_Management_System.Properties.Resources.Add_Shopping_Cart;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(20, 388);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 38);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "         Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Computer_Shop_Management_System.Properties.Resources.Product;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(20, 344);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 38);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "         Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Computer_Shop_Management_System.Properties.Resources.Category;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(20, 300);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 38);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "         Category";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Image = global::Computer_Shop_Management_System.Properties.Resources.Branding;
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(20, 256);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(200, 38);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "         Brand";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Computer_Shop_Management_System.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(20, 168);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 38);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "         Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shop Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSM Backend";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Shop_Management_System.Properties.Resources.Compu;
            this.pictureBox1.Location = new System.Drawing.Point(82, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.lblTimeAndDate);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 61);
            this.panel2.TabIndex = 0;
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeAndDate.Location = new System.Drawing.Point(435, 21);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.Size = new System.Drawing.Size(35, 28);
            this.lblTimeAndDate.TabIndex = 0;
            this.lblTimeAndDate.Text = "{?}";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(173, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(234, 715);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 35);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maybe I Just need to break.";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlDashboard1);
            this.pnlCenter.Controls.Add(this.userControlCategory1);
            this.pnlCenter.Controls.Add(this.userControlBrand1);
            this.pnlCenter.Controls.Add(this.userControlReport1);
            this.pnlCenter.Controls.Add(this.userControlUser1);
            this.pnlCenter.Controls.Add(this.userControlSupplie1);
            this.pnlCenter.Controls.Add(this.userControlOrder1);
            this.pnlCenter.Controls.Add(this.userControlProduct1);
            this.pnlCenter.Controls.Add(this.userControlMember1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(234, 61);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1066, 654);
            this.pnlCenter.TabIndex = 0;
            // 
            // userControlMember1
            // 
            this.userControlMember1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMember1.Location = new System.Drawing.Point(0, 0);
            this.userControlMember1.Name = "userControlMember1";
            this.userControlMember1.Size = new System.Drawing.Size(1066, 654);
            this.userControlMember1.TabIndex = 5;
            this.userControlMember1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1066, 654);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlCategory1
            // 
            this.userControlCategory1.BackColor = System.Drawing.Color.White;
            this.userControlCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCategory1.Location = new System.Drawing.Point(0, 0);
            this.userControlCategory1.Name = "userControlCategory1";
            this.userControlCategory1.Size = new System.Drawing.Size(1066, 654);
            this.userControlCategory1.TabIndex = 0;
            this.userControlCategory1.Visible = false;
            // 
            // userControlBrand1
            // 
            this.userControlBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBrand1.Location = new System.Drawing.Point(0, 0);
            this.userControlBrand1.Name = "userControlBrand1";
            this.userControlBrand1.Size = new System.Drawing.Size(1066, 654);
            this.userControlBrand1.TabIndex = 0;
            this.userControlBrand1.Visible = false;
            // 
            // userControlReport1
            // 
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Location = new System.Drawing.Point(0, 0);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(1066, 654);
            this.userControlReport1.TabIndex = 3;
            this.userControlReport1.Visible = false;
            // 
            // userControlUser1
            // 
            this.userControlUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUser1.Location = new System.Drawing.Point(0, 0);
            this.userControlUser1.Name = "userControlUser1";
            this.userControlUser1.Size = new System.Drawing.Size(1066, 654);
            this.userControlUser1.TabIndex = 4;
            // 
            // userControlSupplie1
            // 
            this.userControlSupplie1.BackColor = System.Drawing.Color.White;
            this.userControlSupplie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSupplie1.Location = new System.Drawing.Point(0, 0);
            this.userControlSupplie1.Name = "userControlSupplie1";
            this.userControlSupplie1.Size = new System.Drawing.Size(1066, 654);
            this.userControlSupplie1.TabIndex = 2;
            this.userControlSupplie1.Visible = false;
            // 
            // userControlOrder1
            // 
            this.userControlOrder1.BackColor = System.Drawing.Color.White;
            this.userControlOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlOrder1.Location = new System.Drawing.Point(0, 0);
            this.userControlOrder1.Name = "userControlOrder1";
            this.userControlOrder1.Size = new System.Drawing.Size(1066, 654);
            this.userControlOrder1.TabIndex = 1;
            this.userControlOrder1.Visible = false;
            // 
            // userControlProduct1
            // 
            this.userControlProduct1.BackColor = System.Drawing.Color.White;
            this.userControlProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProduct1.Location = new System.Drawing.Point(0, 0);
            this.userControlProduct1.Name = "userControlProduct1";
            this.userControlProduct1.Size = new System.Drawing.Size(1066, 654);
            this.userControlProduct1.TabIndex = 0;
            this.userControlProduct1.Visible = false;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSM System | Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.Button btnSuplie;
        private UserControlDashboard userControlDashboard1;
        private UserControlBrand userControlBrand1;
        private UserControlCategory userControlCategory1;
        private UserControlProduct userControlProduct1;
        private UserControlOrder userControlOrder1;
        private UserControlSupplie userControlSupplie1;
        private UserControlReport userControlReport1;
        private UserControlUser userControlUser1;
        private System.Windows.Forms.Button btnMember;
        private UserControlMember userControlMember1;
    }
}