namespace DXTreme.Panels
{
    partial class ListofAdmins
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
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            cmbOrder = new Components.CustomComboBox();
            cmbFilter = new Components.CustomComboBox();
            btnRegister = new test.textBox.RjButton();
            panel1 = new Panel();
            btnPrint = new test.textBox.RjButton();
            panel2 = new Panel();
            admin = new DataGridView();
            colUsername = new DataGridViewTextBoxColumn();
            colAccBranch = new DataGridViewTextBoxColumn();
            colAccType = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            pnlSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)admin).BeginInit();
            SuspendLayout();
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
            pnlSearch.Location = new Point(100, 17);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(71, 65);
            pnlSearch.TabIndex = 1;
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
            btnSearch.Image = Properties.Resources.search2;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 59);
            btnSearch.TabIndex = 0;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            cmbOrder.Items.AddRange(new object[] { "Lowest to Highest", "Highest to Lowest" });
            cmbOrder.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbOrder.ListTextColor = Color.DimGray;
            cmbOrder.Location = new Point(548, 33);
            cmbOrder.MinimumSize = new Size(200, 30);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Padding = new Padding(1);
            cmbOrder.Size = new Size(299, 43);
            cmbOrder.TabIndex = 4;
            cmbOrder.Texts = "ORDER";
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
            cmbFilter.Items.AddRange(new object[] { "Staff's Username", "Assigned Branch", "Account Type", "Status" });
            cmbFilter.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbFilter.ListTextColor = Color.DimGray;
            cmbFilter.Location = new Point(228, 33);
            cmbFilter.MinimumSize = new Size(200, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Padding = new Padding(1);
            cmbFilter.Size = new Size(299, 43);
            cmbFilter.TabIndex = 3;
            cmbFilter.Texts = "SEARCH BY";
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
            btnRegister.Location = new Point(892, 16);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 64);
            btnRegister.TabIndex = 5;
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(cmbOrder);
            panel1.Controls.Add(pnlSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 88);
            panel1.TabIndex = 0;
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
            btnPrint.Location = new Point(1215, 17);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 64);
            btnPrint.TabIndex = 8;
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1328, 10);
            panel2.TabIndex = 7;
            // 
            // admin
            // 
            admin.AllowUserToAddRows = false;
            admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            admin.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            admin.ColumnHeadersHeight = 50;
            admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            admin.Columns.AddRange(new DataGridViewColumn[] { colUsername, colAccBranch, colAccType, colStatus, btnEdit, btnDelete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            admin.DefaultCellStyle = dataGridViewCellStyle4;
            admin.Dock = DockStyle.Fill;
            admin.Location = new Point(0, 88);
            admin.Name = "admin";
            admin.RowHeadersVisible = false;
            admin.Size = new Size(1328, 737);
            admin.TabIndex = 1;
            admin.CellClick += admin_CellClick;
            admin.CellPainting += admin_CellPainting;
            // 
            // colUsername
            // 
            colUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            colUsername.DefaultCellStyle = dataGridViewCellStyle2;
            colUsername.FillWeight = 87.05584F;
            colUsername.HeaderText = "List of Staff's Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Resizable = DataGridViewTriState.False;
            // 
            // colAccBranch
            // 
            colAccBranch.HeaderText = "Assigned Branch";
            colAccBranch.Name = "colAccBranch";
            colAccBranch.ReadOnly = true;
            colAccBranch.Resizable = DataGridViewTriState.False;
            // 
            // colAccType
            // 
            colAccType.HeaderText = "Account Type";
            colAccType.Name = "colAccType";
            colAccType.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStatus.FillWeight = 87.05584F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Resizable = DataGridViewTriState.False;
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
            // ListofAdmins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1328, 825);
            Controls.Add(admin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListofAdmins";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListofAdmins";
            pnlSearch.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)admin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private test.panel pnlSearch;
        private test.textBox.RjButton btnSearch;
        private Components.CustomComboBox cmbOrder;
        private Components.CustomComboBox cmbFilter;
        private test.textBox.RjButton btnRegister;
        private Panel panel1;
        private Panel panel2;
        private DataGridView admin;
        private test.textBox.RjButton btnPrint;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colAccBranch;
        private DataGridViewTextBoxColumn colAccType;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private test.textBox.textBox txtSearch;
    }
}