namespace Computer_Shop_Management_System.PAL
{
    partial class UserControlUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tpAddUser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageUsers = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtUserName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tcUser.SuspendLayout();
            this.tpAddUser.SuspendLayout();
            this.tpManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUser
            // 
            this.tcUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcUser.Controls.Add(this.tpAddUser);
            this.tcUser.Controls.Add(this.tpManageUsers);
            this.tcUser.Controls.Add(this.tpOptions);
            this.tcUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUser.Location = new System.Drawing.Point(0, 0);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(1066, 651);
            this.tcUser.TabIndex = 0;
            // 
            // tpAddUser
            // 
            this.tpAddUser.Controls.Add(this.label4);
            this.tpAddUser.Controls.Add(this.txtPassword);
            this.tpAddUser.Controls.Add(this.label3);
            this.tpAddUser.Controls.Add(this.txtEmail);
            this.tpAddUser.Controls.Add(this.btnAdd);
            this.tpAddUser.Controls.Add(this.txtUserName);
            this.tpAddUser.Controls.Add(this.label2);
            this.tpAddUser.Controls.Add(this.label1);
            this.tpAddUser.Location = new System.Drawing.Point(4, 4);
            this.tpAddUser.Name = "tpAddUser";
            this.tpAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddUser.Size = new System.Drawing.Size(1058, 618);
            this.tpAddUser.TabIndex = 0;
            this.tpAddUser.Text = "Add User";
            this.tpAddUser.UseVisualStyleBackColor = true;
            this.tpAddUser.Enter += new System.EventHandler(this.tpAddUser_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(49, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(52, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(291, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(366, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emaii:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(370, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(53, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(53, 130);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(291, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add User";
            // 
            // tpManageUsers
            // 
            this.tpManageUsers.Controls.Add(this.dgvUser);
            this.tpManageUsers.Controls.Add(this.lblTotal);
            this.tpManageUsers.Controls.Add(this.label6);
            this.tpManageUsers.Controls.Add(this.txtSearchUserName);
            this.tpManageUsers.Controls.Add(this.label5);
            this.tpManageUsers.Controls.Add(this.label7);
            this.tpManageUsers.Controls.Add(this.picSearch);
            this.tpManageUsers.Location = new System.Drawing.Point(4, 4);
            this.tpManageUsers.Name = "tpManageUsers";
            this.tpManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageUsers.Size = new System.Drawing.Size(1058, 618);
            this.tpManageUsers.TabIndex = 1;
            this.tpManageUsers.Text = "Manage Users";
            this.tpManageUsers.UseVisualStyleBackColor = true;
            this.tpManageUsers.Enter += new System.EventHandler(this.tpManageUsers_Enter);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 29;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(25, 158);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.ShowCellErrors = false;
            this.dgvUser.ShowCellToolTips = false;
            this.dgvUser.ShowEditingIcon = false;
            this.dgvUser.ShowRowErrors = false;
            this.dgvUser.Size = new System.Drawing.Size(1010, 330);
            this.dgvUser.TabIndex = 13;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Users_Id";
            this.Column1.HeaderText = "User #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Users_Name";
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Users_Email";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Users_Password";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(73, 491);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUserName.Location = new System.Drawing.Point(363, 102);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(266, 27);
            this.txtSearchUserName.TabIndex = 1;
            this.txtSearchUserName.TextChanged += new System.EventHandler(this.txtSearchUserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(359, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Users Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "../Manage User";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::Computer_Shop_Management_System.Properties.Resources.Search2;
            this.picSearch.Location = new System.Drawing.Point(628, 103);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(31, 28);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 12;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.btnChange);
            this.tpOptions.Controls.Add(this.btnRemove);
            this.tpOptions.Controls.Add(this.label8);
            this.tpOptions.Controls.Add(this.txtPassword1);
            this.tpOptions.Controls.Add(this.label9);
            this.tpOptions.Controls.Add(this.txtEmail1);
            this.tpOptions.Controls.Add(this.txtUserName1);
            this.tpOptions.Controls.Add(this.label10);
            this.tpOptions.Controls.Add(this.label11);
            this.tpOptions.Location = new System.Drawing.Point(4, 4);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(1058, 618);
            this.tpOptions.TabIndex = 2;
            this.tpOptions.Text = "Options";
            this.tpOptions.UseVisualStyleBackColor = true;
            this.tpOptions.Enter += new System.EventHandler(this.tpOptions_Enter);
            this.tpOptions.Leave += new System.EventHandler(this.tpOptions_Leave);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(55, 270);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(109, 38);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(171, 270);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 38);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(52, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password:";
            // 
            // txtPassword1
            // 
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword1.Location = new System.Drawing.Point(55, 200);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(291, 27);
            this.txtPassword1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(369, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Emaii:";
            // 
            // txtEmail1
            // 
            this.txtEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail1.Location = new System.Drawing.Point(373, 128);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(291, 27);
            this.txtEmail1.TabIndex = 2;
            // 
            // txtUserName1
            // 
            this.txtUserName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName1.Location = new System.Drawing.Point(56, 130);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(291, 27);
            this.txtUserName1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(52, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "User Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "../Options";
            // 
            // UserControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcUser);
            this.Name = "UserControlUser";
            this.Size = new System.Drawing.Size(1066, 654);
            this.tcUser.ResumeLayout(false);
            this.tpAddUser.ResumeLayout(false);
            this.tpAddUser.PerformLayout();
            this.tpManageUsers.ResumeLayout(false);
            this.tpManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.TabPage tpManageUsers;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtUserName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
