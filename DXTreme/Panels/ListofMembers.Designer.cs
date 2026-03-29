namespace DXTreme.Panels
{
    partial class ListofMembers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            btnPrint = new test.textBox.RjButton();
            cmbFilter = new Components.CustomComboBox();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            cmbOrder = new Components.CustomComboBox();
            btnRegister = new test.textBox.RjButton();
            listofmember = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colOpt = new DataGridViewTextBoxColumn();
            colMem = new DataGridViewTextBoxColumn();
            colExpire = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listofmember).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(cmbOrder);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 0, 0);
            panel1.Size = new Size(1277, 88);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 10);
            panel2.TabIndex = 4;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.MidnightBlue;
            btnPrint.BackgroundColor = Color.MidnightBlue;
            btnPrint.BorderColor = Color.PaleVioletRed;
            btnPrint.BorderRadius = 10;
            btnPrint.BorderSize = 0;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Image = Properties.Resources.Print;
            btnPrint.Location = new Point(1144, 18);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 64);
            btnPrint.TabIndex = 3;
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Right;
            cmbFilter.BackColor = Color.WhiteSmoke;
            cmbFilter.BorderColor = Color.Maroon;
            cmbFilter.BorderSize = 1;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDown;
            cmbFilter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbFilter.ForeColor = Color.Black;
            cmbFilter.IconColor = Color.Maroon;
            cmbFilter.Items.AddRange(new object[] { "Name", "Membership Type", "Membership Option", "Date of Membership", "Date of Expiration" });
            cmbFilter.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbFilter.ListTextColor = Color.Black;
            cmbFilter.Location = new Point(217, 35);
            cmbFilter.MinimumSize = new Size(200, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Padding = new Padding(1);
            cmbFilter.Size = new Size(299, 43);
            cmbFilter.TabIndex = 1;
            cmbFilter.Texts = "SEARCH BY";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(20, 33, 36);
            pnlSearch.BorderRadius = 55;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.ForeColor = Color.Black;
            pnlSearch.GradientAngle = 90F;
            pnlSearch.GradientBottomColor = Color.FromArgb(224, 224, 224);
            pnlSearch.GradientTopColor = Color.FromArgb(224, 224, 224);
            pnlSearch.Location = new Point(94, 20);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(71, 65);
            pnlSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(224, 224, 224);
            txtSearch.BorderColor = Color.FromArgb(64, 64, 64);
            txtSearch.BorderFocusColor = Color.Blue;
            txtSearch.BorderRadius = 0;
            txtSearch.BorderSize = 2;
            txtSearch.Editable = false;
            txtSearch.Font = new Font("Georgia", 12F, FontStyle.Bold);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(75, 16);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(10, 7, 10, 7);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(366, 40);
            txtSearch.TabIndex = 1;
            txtSearch.Texts = "";
            txtSearch.UnderlinedStyle = true;
            txtSearch._TextChanged += txtSearch__TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.BackgroundColor = Color.MidnightBlue;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 30;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search3;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 59);
            btnSearch.TabIndex = 0;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.MouseClick += btnSearch_MouseClick;
            // 
            // cmbOrder
            // 
            cmbOrder.Anchor = AnchorStyles.Right;
            cmbOrder.BackColor = Color.WhiteSmoke;
            cmbOrder.BorderColor = Color.Maroon;
            cmbOrder.BorderSize = 1;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDown;
            cmbOrder.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbOrder.ForeColor = Color.Black;
            cmbOrder.IconColor = Color.Maroon;
            cmbOrder.Items.AddRange(new object[] { "Highest to Lowest", "Lowest to Highest" });
            cmbOrder.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbOrder.ListTextColor = Color.DimGray;
            cmbOrder.Location = new Point(546, 35);
            cmbOrder.MinimumSize = new Size(200, 30);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Padding = new Padding(1);
            cmbOrder.Size = new Size(299, 43);
            cmbOrder.TabIndex = 2;
            cmbOrder.Texts = "ORDER";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackColor = Color.MidnightBlue;
            btnRegister.BackgroundColor = Color.MidnightBlue;
            btnRegister.BorderColor = Color.PaleVioletRed;
            btnRegister.BorderRadius = 10;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Image = Properties.Resources.Register1;
            btnRegister.Location = new Point(1009, 18);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 64);
            btnRegister.TabIndex = 1;
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // listofmember
            // 
            listofmember.AllowUserToAddRows = false;
            listofmember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listofmember.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listofmember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listofmember.ColumnHeadersHeight = 50;
            listofmember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            listofmember.Columns.AddRange(new DataGridViewColumn[] { colName, colType, colOpt, colMem, colExpire, btnEdit, btnDelete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            listofmember.DefaultCellStyle = dataGridViewCellStyle4;
            listofmember.Dock = DockStyle.Fill;
            listofmember.Location = new Point(0, 88);
            listofmember.Name = "listofmember";
            listofmember.RowHeadersVisible = false;
            listofmember.Size = new Size(1277, 642);
            listofmember.TabIndex = 0;
            listofmember.CellClick += listofmember_CellClick;
            listofmember.CellPainting += listofmember_CellPainting;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            colName.DefaultCellStyle = dataGridViewCellStyle2;
            colName.FillWeight = 87.05584F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            // 
            // colType
            // 
            colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colType.FillWeight = 87.05584F;
            colType.HeaderText = "Membership Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            colType.Resizable = DataGridViewTriState.False;
            // 
            // colOpt
            // 
            colOpt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colOpt.FillWeight = 87.05584F;
            colOpt.HeaderText = "Membership Option";
            colOpt.Name = "colOpt";
            colOpt.ReadOnly = true;
            colOpt.Resizable = DataGridViewTriState.False;
            // 
            // colMem
            // 
            colMem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMem.FillWeight = 87.05584F;
            colMem.HeaderText = "Date of Membership";
            colMem.Name = "colMem";
            colMem.ReadOnly = true;
            colMem.Resizable = DataGridViewTriState.False;
            // 
            // colExpire
            // 
            colExpire.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colExpire.FillWeight = 87.05584F;
            colExpire.HeaderText = "Date of Expiration";
            colExpire.Name = "colExpire";
            colExpire.ReadOnly = true;
            colExpire.Resizable = DataGridViewTriState.False;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnEdit.FillWeight = 177.664978F;
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Resizable = DataGridViewTriState.False;
            btnEdit.Text = "";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 48;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Maroon;
            btnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            btnDelete.FillWeight = 87.05584F;
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Resizable = DataGridViewTriState.False;
            btnDelete.Text = "";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 65;
            // 
            // ListofMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1277, 730);
            Controls.Add(listofmember);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListofMembers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListofMembers";
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listofmember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private test.panel pnlSearch;
        private test.textBox.RjButton btnSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnRegister;
        private Components.CustomComboBox cmbFilter;
        private Components.CustomComboBox cmbOrder;
        private DataGridView listofmember;
        private test.textBox.RjButton btnPrint;
        private Panel panel2;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colOpt;
        private DataGridViewTextBoxColumn colMem;
        private DataGridViewTextBoxColumn colExpire;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}