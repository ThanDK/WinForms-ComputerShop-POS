namespace Computer_Shop_Management_System.PAL
{
    partial class UserControlBrand
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
            this.tcBrand = new System.Windows.Forms.TabControl();
            this.tpAddBrand = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageBrand = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBrandName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbStatus1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrandName1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcBrand.SuspendLayout();
            this.tpAddBrand.SuspendLayout();
            this.tpManageBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBrand
            // 
            this.tcBrand.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcBrand.Controls.Add(this.tpAddBrand);
            this.tcBrand.Controls.Add(this.tpManageBrand);
            this.tcBrand.Controls.Add(this.tpOptions);
            this.tcBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBrand.Location = new System.Drawing.Point(0, 0);
            this.tcBrand.Name = "tcBrand";
            this.tcBrand.Padding = new System.Drawing.Point(3, 3);
            this.tcBrand.SelectedIndex = 0;
            this.tcBrand.Size = new System.Drawing.Size(1066, 651);
            this.tcBrand.TabIndex = 0;
            // 
            // tpAddBrand
            // 
            this.tpAddBrand.Controls.Add(this.btnAdd);
            this.tpAddBrand.Controls.Add(this.cmbStatus);
            this.tpAddBrand.Controls.Add(this.label3);
            this.tpAddBrand.Controls.Add(this.txtBrandName);
            this.tpAddBrand.Controls.Add(this.label2);
            this.tpAddBrand.Controls.Add(this.label1);
            this.tpAddBrand.Location = new System.Drawing.Point(4, 4);
            this.tpAddBrand.Name = "tpAddBrand";
            this.tpAddBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddBrand.Size = new System.Drawing.Size(1058, 618);
            this.tpAddBrand.TabIndex = 0;
            this.tpAddBrand.Text = "Add Brand";
            this.tpAddBrand.UseVisualStyleBackColor = true;
            this.tpAddBrand.Enter += new System.EventHandler(this.tpAddBrand_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(55, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "--SELECT--",
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(370, 128);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(291, 28);
            this.cmbStatus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(366, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName.Location = new System.Drawing.Point(56, 129);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(291, 27);
            this.txtBrandName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brand Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Brand";
            // 
            // tpManageBrand
            // 
            this.tpManageBrand.Controls.Add(this.lblTotal);
            this.tpManageBrand.Controls.Add(this.label6);
            this.tpManageBrand.Controls.Add(this.dgvBrand);
            this.tpManageBrand.Controls.Add(this.txtSearchBrandName);
            this.tpManageBrand.Controls.Add(this.label4);
            this.tpManageBrand.Controls.Add(this.label5);
            this.tpManageBrand.Controls.Add(this.picSearch);
            this.tpManageBrand.Location = new System.Drawing.Point(4, 4);
            this.tpManageBrand.Name = "tpManageBrand";
            this.tpManageBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageBrand.Size = new System.Drawing.Size(1058, 618);
            this.tpManageBrand.TabIndex = 1;
            this.tpManageBrand.Text = "Manage Brand";
            this.tpManageBrand.UseVisualStyleBackColor = true;
            this.tpManageBrand.Enter += new System.EventHandler(this.tpManageBrand_Enter);
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
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToAddRows = false;
            this.dgvBrand.AllowUserToDeleteRows = false;
            this.dgvBrand.AllowUserToResizeColumns = false;
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.White;
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.ColumnHeadersHeight = 29;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.Location = new System.Drawing.Point(25, 160);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersWidth = 51;
            this.dgvBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrand.RowTemplate.Height = 24;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.ShowCellErrors = false;
            this.dgvBrand.ShowCellToolTips = false;
            this.dgvBrand.ShowEditingIcon = false;
            this.dgvBrand.ShowRowErrors = false;
            this.dgvBrand.Size = new System.Drawing.Size(1010, 330);
            this.dgvBrand.TabIndex = 0;
            this.dgvBrand.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Brand_Id";
            this.Column1.HeaderText = "Brand #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Brand_Name";
            this.Column2.HeaderText = "Brand Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Brand_Status";
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtSearchBrandName
            // 
            this.txtSearchBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBrandName.Location = new System.Drawing.Point(363, 102);
            this.txtSearchBrandName.Name = "txtSearchBrandName";
            this.txtSearchBrandName.Size = new System.Drawing.Size(266, 27);
            this.txtSearchBrandName.TabIndex = 2;
            this.txtSearchBrandName.TextChanged += new System.EventHandler(this.txtSearchBrandName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(359, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Brand Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "../Manage Brand";
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
            this.picSearch.TabIndex = 5;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.btnRemove);
            this.tpOptions.Controls.Add(this.btnChange);
            this.tpOptions.Controls.Add(this.cmbStatus1);
            this.tpOptions.Controls.Add(this.label8);
            this.tpOptions.Controls.Add(this.txtBrandName1);
            this.tpOptions.Controls.Add(this.label9);
            this.tpOptions.Controls.Add(this.label10);
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
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(167, 183);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(52, 183);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(109, 38);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cmbStatus1
            // 
            this.cmbStatus1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus1.FormattingEnabled = true;
            this.cmbStatus1.Items.AddRange(new object[] {
            "--SELECT--",
            "Available",
            "Not Available"});
            this.cmbStatus1.Location = new System.Drawing.Point(367, 128);
            this.cmbStatus1.Name = "cmbStatus1";
            this.cmbStatus1.Size = new System.Drawing.Size(291, 28);
            this.cmbStatus1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(363, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status:";
            // 
            // txtBrandName1
            // 
            this.txtBrandName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName1.Location = new System.Drawing.Point(53, 129);
            this.txtBrandName1.Name = "txtBrandName1";
            this.txtBrandName1.Size = new System.Drawing.Size(291, 27);
            this.txtBrandName1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(49, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Brand Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "../Options";
            // 
            // UserControlBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcBrand);
            this.Name = "UserControlBrand";
            this.Size = new System.Drawing.Size(1066, 654);
            this.tcBrand.ResumeLayout(false);
            this.tpAddBrand.ResumeLayout(false);
            this.tpAddBrand.PerformLayout();
            this.tpManageBrand.ResumeLayout(false);
            this.tpManageBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBrand;
        private System.Windows.Forms.TabPage tpAddBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpManageBrand;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearchBrandName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbStatus1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrandName1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
