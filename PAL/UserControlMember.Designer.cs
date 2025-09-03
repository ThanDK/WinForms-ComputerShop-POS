namespace Computer_Shop_Management_System.PAL
{
    partial class UserControlMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMember = new System.Windows.Forms.TabControl();
            this.tpAddMember = new System.Windows.Forms.TabPage();
            this.mtbCustomerNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageMember = new System.Windows.Forms.TabPage();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchMembersName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mtbCustomerNumber1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerEmail1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tcMember.SuspendLayout();
            this.tpAddMember.SuspendLayout();
            this.tpManageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMember
            // 
            this.tcMember.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMember.Controls.Add(this.tpAddMember);
            this.tcMember.Controls.Add(this.tpManageMember);
            this.tcMember.Controls.Add(this.tpOptions);
            this.tcMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMember.Location = new System.Drawing.Point(0, 0);
            this.tcMember.Name = "tcMember";
            this.tcMember.SelectedIndex = 0;
            this.tcMember.Size = new System.Drawing.Size(1066, 651);
            this.tcMember.TabIndex = 0;
            // 
            // tpAddMember
            // 
            this.tpAddMember.Controls.Add(this.mtbCustomerNumber);
            this.tpAddMember.Controls.Add(this.label4);
            this.tpAddMember.Controls.Add(this.txtCustomerEmail);
            this.tpAddMember.Controls.Add(this.label3);
            this.tpAddMember.Controls.Add(this.btnAdd);
            this.tpAddMember.Controls.Add(this.txtCustomerName);
            this.tpAddMember.Controls.Add(this.label2);
            this.tpAddMember.Controls.Add(this.label1);
            this.tpAddMember.Location = new System.Drawing.Point(4, 4);
            this.tpAddMember.Name = "tpAddMember";
            this.tpAddMember.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddMember.Size = new System.Drawing.Size(1058, 618);
            this.tpAddMember.TabIndex = 0;
            this.tpAddMember.Text = "Add Member";
            this.tpAddMember.UseVisualStyleBackColor = true;
            this.tpAddMember.Enter += new System.EventHandler(this.tpAddMember_Enter);
            // 
            // mtbCustomerNumber
            // 
            this.mtbCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCustomerNumber.Location = new System.Drawing.Point(366, 130);
            this.mtbCustomerNumber.Mask = "000-000";
            this.mtbCustomerNumber.Name = "mtbCustomerNumber";
            this.mtbCustomerNumber.Size = new System.Drawing.Size(291, 27);
            this.mtbCustomerNumber.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Email:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerEmail.Location = new System.Drawing.Point(48, 200);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(291, 27);
            this.txtCustomerEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(362, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(49, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(49, 130);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(291, 27);
            this.txtCustomerName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "../Add Member";
            // 
            // tpManageMember
            // 
            this.tpManageMember.Controls.Add(this.dgvMembers);
            this.tpManageMember.Controls.Add(this.lblTotal);
            this.tpManageMember.Controls.Add(this.label6);
            this.tpManageMember.Controls.Add(this.txtSearchMembersName);
            this.tpManageMember.Controls.Add(this.label5);
            this.tpManageMember.Controls.Add(this.label7);
            this.tpManageMember.Controls.Add(this.picSearch);
            this.tpManageMember.Location = new System.Drawing.Point(4, 4);
            this.tpManageMember.Name = "tpManageMember";
            this.tpManageMember.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageMember.Size = new System.Drawing.Size(1058, 618);
            this.tpManageMember.TabIndex = 1;
            this.tpManageMember.Text = "Manage Members";
            this.tpManageMember.UseVisualStyleBackColor = true;
            this.tpManageMember.Enter += new System.EventHandler(this.tpManageMember_Enter);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeColumns = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.ColumnHeadersHeight = 29;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.Location = new System.Drawing.Point(28, 158);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.ShowCellErrors = false;
            this.dgvMembers.ShowCellToolTips = false;
            this.dgvMembers.ShowEditingIcon = false;
            this.dgvMembers.ShowRowErrors = false;
            this.dgvMembers.Size = new System.Drawing.Size(1010, 330);
            this.dgvMembers.TabIndex = 20;
            this.dgvMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Members_Id";
            this.Column1.HeaderText = "Members #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Members_Name";
            this.Column2.HeaderText = "Members Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Members_Number";
            this.Column3.HeaderText = "Members Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Members_Email";
            this.Column4.HeaderText = "Members Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(76, 491);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(24, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // txtSearchMembersName
            // 
            this.txtSearchMembersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMembersName.Location = new System.Drawing.Point(366, 102);
            this.txtSearchMembersName.Name = "txtSearchMembersName";
            this.txtSearchMembersName.Size = new System.Drawing.Size(266, 27);
            this.txtSearchMembersName.TabIndex = 17;
            this.txtSearchMembersName.TextChanged += new System.EventHandler(this.txtSearchMembersName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(362, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Members Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "../Manage Members";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::Computer_Shop_Management_System.Properties.Resources.Search2;
            this.picSearch.Location = new System.Drawing.Point(631, 103);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(31, 28);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 19;
            this.picSearch.TabStop = false;
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.btnChange);
            this.tpOptions.Controls.Add(this.btnRemove);
            this.tpOptions.Controls.Add(this.mtbCustomerNumber1);
            this.tpOptions.Controls.Add(this.label8);
            this.tpOptions.Controls.Add(this.txtCustomerEmail1);
            this.tpOptions.Controls.Add(this.label9);
            this.tpOptions.Controls.Add(this.txtCustomerName1);
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
            this.btnChange.Location = new System.Drawing.Point(56, 270);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(109, 38);
            this.btnChange.TabIndex = 22;
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
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // mtbCustomerNumber1
            // 
            this.mtbCustomerNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCustomerNumber1.Location = new System.Drawing.Point(373, 130);
            this.mtbCustomerNumber1.Mask = "000-000";
            this.mtbCustomerNumber1.Name = "mtbCustomerNumber1";
            this.mtbCustomerNumber1.Size = new System.Drawing.Size(291, 27);
            this.mtbCustomerNumber1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(52, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer Email:";
            // 
            // txtCustomerEmail1
            // 
            this.txtCustomerEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerEmail1.Location = new System.Drawing.Point(55, 200);
            this.txtCustomerEmail1.Name = "txtCustomerEmail1";
            this.txtCustomerEmail1.Size = new System.Drawing.Size(291, 27);
            this.txtCustomerEmail1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(369, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer Number:";
            // 
            // txtCustomerName1
            // 
            this.txtCustomerName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName1.Location = new System.Drawing.Point(56, 130);
            this.txtCustomerName1.Name = "txtCustomerName1";
            this.txtCustomerName1.Size = new System.Drawing.Size(291, 27);
            this.txtCustomerName1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(52, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Customer Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "../Options";
            // 
            // UserControlMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMember);
            this.Name = "UserControlMember";
            this.Size = new System.Drawing.Size(1066, 654);
            this.tcMember.ResumeLayout(false);
            this.tpAddMember.ResumeLayout(false);
            this.tpAddMember.PerformLayout();
            this.tpManageMember.ResumeLayout(false);
            this.tpManageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMember;
        private System.Windows.Forms.TabPage tpAddMember;
        private System.Windows.Forms.TabPage tpManageMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCustomerNumber;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchMembersName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.MaskedTextBox mtbCustomerNumber1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerEmail1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
    }
}
