namespace Computer_Shop_Management_System.PAL
{
    partial class UserControlCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcCategory = new System.Windows.Forms.TabControl();
            this.tpAddCategory = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageCategory = new System.Windows.Forms.TabPage();
            this.txtSearchCategoryName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbStatus1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoryName1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcCategory.SuspendLayout();
            this.tpAddCategory.SuspendLayout();
            this.tpManageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCategory
            // 
            this.tcCategory.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcCategory.Controls.Add(this.tpAddCategory);
            this.tcCategory.Controls.Add(this.tpManageCategory);
            this.tcCategory.Controls.Add(this.tpOptions);
            this.tcCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCategory.Location = new System.Drawing.Point(0, 0);
            this.tcCategory.Name = "tcCategory";
            this.tcCategory.Padding = new System.Drawing.Point(3, 3);
            this.tcCategory.SelectedIndex = 0;
            this.tcCategory.Size = new System.Drawing.Size(1066, 651);
            this.tcCategory.TabIndex = 0;
            // 
            // tpAddCategory
            // 
            this.tpAddCategory.Controls.Add(this.btnAdd);
            this.tpAddCategory.Controls.Add(this.cmbStatus);
            this.tpAddCategory.Controls.Add(this.label3);
            this.tpAddCategory.Controls.Add(this.txtCategoryName);
            this.tpAddCategory.Controls.Add(this.label2);
            this.tpAddCategory.Controls.Add(this.label1);
            this.tpAddCategory.Location = new System.Drawing.Point(4, 4);
            this.tpAddCategory.Name = "tpAddCategory";
            this.tpAddCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCategory.Size = new System.Drawing.Size(1058, 618);
            this.tpAddCategory.TabIndex = 0;
            this.tpAddCategory.Text = "Add Category";
            this.tpAddCategory.UseVisualStyleBackColor = true;
            this.tpAddCategory.Enter += new System.EventHandler(this.tpAddCategory_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(52, 183);
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
            this.cmbStatus.Location = new System.Drawing.Point(367, 128);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(291, 28);
            this.cmbStatus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(363, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Location = new System.Drawing.Point(53, 129);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(291, 27);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Category";
            // 
            // tpManageCategory
            // 
            this.tpManageCategory.Controls.Add(this.txtSearchCategoryName);
            this.tpManageCategory.Controls.Add(this.lblTotal);
            this.tpManageCategory.Controls.Add(this.label6);
            this.tpManageCategory.Controls.Add(this.dgvCategory);
            this.tpManageCategory.Controls.Add(this.label4);
            this.tpManageCategory.Controls.Add(this.label5);
            this.tpManageCategory.Controls.Add(this.picSearch);
            this.tpManageCategory.Location = new System.Drawing.Point(4, 4);
            this.tpManageCategory.Name = "tpManageCategory";
            this.tpManageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageCategory.Size = new System.Drawing.Size(1058, 618);
            this.tpManageCategory.TabIndex = 1;
            this.tpManageCategory.Text = "Manage Category";
            this.tpManageCategory.UseVisualStyleBackColor = true;
            this.tpManageCategory.Enter += new System.EventHandler(this.tpManageCategory_Enter);
            // 
            // txtSearchCategoryName
            // 
            this.txtSearchCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCategoryName.Location = new System.Drawing.Point(363, 102);
            this.txtSearchCategoryName.Name = "txtSearchCategoryName";
            this.txtSearchCategoryName.Size = new System.Drawing.Size(266, 27);
            this.txtSearchCategoryName.TabIndex = 1;
            this.txtSearchCategoryName.TextChanged += new System.EventHandler(this.txtSearchCategoryName_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(73, 493);
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
            this.label6.Location = new System.Drawing.Point(21, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.ColumnHeadersHeight = 29;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Location = new System.Drawing.Point(25, 160);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.ShowCellErrors = false;
            this.dgvCategory.ShowCellToolTips = false;
            this.dgvCategory.ShowEditingIcon = false;
            this.dgvCategory.ShowRowErrors = false;
            this.dgvCategory.Size = new System.Drawing.Size(1010, 330);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Category_Id";
            this.Column1.HeaderText = "Category #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Category_Name";
            this.Column2.HeaderText = "Category Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Category_Status";
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(359, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "../Manage Category";
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
            this.tpOptions.Controls.Add(this.btnRemove);
            this.tpOptions.Controls.Add(this.btnChange);
            this.tpOptions.Controls.Add(this.cmbStatus1);
            this.tpOptions.Controls.Add(this.label7);
            this.tpOptions.Controls.Add(this.txtCategoryName1);
            this.tpOptions.Controls.Add(this.label8);
            this.tpOptions.Controls.Add(this.label9);
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
            this.btnRemove.Location = new System.Drawing.Point(170, 183);
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
            this.btnChange.Location = new System.Drawing.Point(55, 183);
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
            this.cmbStatus1.Location = new System.Drawing.Point(370, 128);
            this.cmbStatus1.Name = "cmbStatus1";
            this.cmbStatus1.Size = new System.Drawing.Size(291, 28);
            this.cmbStatus1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(366, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // txtCategoryName1
            // 
            this.txtCategoryName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName1.Location = new System.Drawing.Point(56, 129);
            this.txtCategoryName1.Name = "txtCategoryName1";
            this.txtCategoryName1.Size = new System.Drawing.Size(291, 27);
            this.txtCategoryName1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(52, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Category Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Options";
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcCategory);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(1066, 654);
            this.tcCategory.ResumeLayout(false);
            this.tpAddCategory.ResumeLayout(false);
            this.tpAddCategory.PerformLayout();
            this.tpManageCategory.ResumeLayout(false);
            this.tpManageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCategory;
        private System.Windows.Forms.TabPage tpAddCategory;
        private System.Windows.Forms.TabPage tpManageCategory;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbStatus1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategoryName1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemove;
    }
}
