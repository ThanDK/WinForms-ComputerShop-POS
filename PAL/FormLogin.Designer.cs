namespace Computer_Shop_Management_System.PAL
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSM System | Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(141, 311);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(291, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Admin";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(141, 378);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "1234";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(137, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPassword.Location = new System.Drawing.Point(218, 415);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(130, 20);
            this.lbForgotPassword.TabIndex = 0;
            this.lbForgotPassword.Text = "Forgot Password?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(141, 458);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(291, 39);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShow.Image = global::Computer_Shop_Management_System.Properties.Resources.Eye;
            this.picShow.Location = new System.Drawing.Point(396, 378);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(36, 28);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 9;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // picHide
            // 
            this.picHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHide.Image = global::Computer_Shop_Management_System.Properties.Resources.Hide;
            this.picHide.Location = new System.Drawing.Point(396, 378);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(36, 28);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 8;
            this.picHide.TabStop = false;
            this.picHide.Visible = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Computer_Shop_Management_System.Properties.Resources.Worksd;
            this.pictureBox3.Location = new System.Drawing.Point(174, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Computer_Shop_Management_System.Properties.Resources.Close;
            this.picClose.Location = new System.Drawing.Point(519, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Shop_Management_System.Properties.Resources.Workstation;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 560);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSM System|Log In";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.Button btnLogIn;
    }
}