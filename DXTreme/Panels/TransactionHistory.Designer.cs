namespace DXTreme.Panels
{
    partial class TransactionHistory
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnPrint = new test.textBox.RjButton();
            cmbFilter = new Components.CustomComboBox();
            cmbOrder = new Components.CustomComboBox();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            transactionList = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colClient = new DataGridViewTextBoxColumn();
            colDnT = new DataGridViewTextBoxColumn();
            colAct = new DataGridViewTextBoxColumn();
            colPhp = new DataGridViewTextBoxColumn();
            btnDel = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(cmbOrder);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 88);
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
            btnPrint.Location = new Point(1159, 17);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 64);
            btnPrint.TabIndex = 7;
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
            cmbFilter.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbFilter.ListTextColor = Color.DimGray;
            cmbFilter.Location = new Point(322, 29);
            cmbFilter.MinimumSize = new Size(200, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Padding = new Padding(1);
            cmbFilter.Size = new Size(299, 43);
            cmbFilter.TabIndex = 5;
            cmbFilter.Texts = "FILTER";
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
            cmbOrder.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbOrder.ListTextColor = Color.DimGray;
            cmbOrder.Location = new Point(651, 29);
            cmbOrder.MinimumSize = new Size(200, 30);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Padding = new Padding(1);
            cmbOrder.Size = new Size(299, 43);
            cmbOrder.TabIndex = 6;
            cmbOrder.Texts = "ORDER";
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
            pnlSearch.Location = new Point(182, 16);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(71, 65);
            pnlSearch.TabIndex = 2;
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
            btnSearch.MouseClick += btnSearch_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1272, 10);
            panel2.TabIndex = 0;
            // 
            // transactionList
            // 
            transactionList.AllowUserToAddRows = false;
            transactionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionList.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Navy;
            dataGridViewCellStyle5.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            transactionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            transactionList.ColumnHeadersHeight = 50;
            transactionList.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colClient, colDnT, colAct, colPhp, btnDel });
            transactionList.Dock = DockStyle.Fill;
            transactionList.Location = new Point(0, 88);
            transactionList.Name = "transactionList";
            transactionList.RowHeadersVisible = false;
            transactionList.Size = new Size(1272, 766);
            transactionList.TabIndex = 2;
            transactionList.CellClick += transactionList_CellClick;
            transactionList.CellPainting += transactionList_CellPainting;
            // 
            // colID
            // 
            colID.HeaderText = "Transaction ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Resizable = DataGridViewTriState.False;
            colID.Visible = false;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            colName.DefaultCellStyle = dataGridViewCellStyle6;
            colName.FillWeight = 58.5720367F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            // 
            // colClient
            // 
            colClient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colClient.FillWeight = 58.5720367F;
            colClient.HeaderText = "Client";
            colClient.Name = "colClient";
            colClient.ReadOnly = true;
            colClient.Resizable = DataGridViewTriState.False;
            // 
            // colDnT
            // 
            colDnT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDnT.FillWeight = 58.5720367F;
            colDnT.HeaderText = "Date & Time";
            colDnT.Name = "colDnT";
            colDnT.ReadOnly = true;
            colDnT.Resizable = DataGridViewTriState.False;
            // 
            // colAct
            // 
            colAct.FillWeight = 67.281F;
            colAct.HeaderText = "Activity";
            colAct.Name = "colAct";
            colAct.ReadOnly = true;
            colAct.Resizable = DataGridViewTriState.False;
            // 
            // colPhp
            // 
            colPhp.FillWeight = 67.281F;
            colPhp.HeaderText = "Amount";
            colPhp.Name = "colPhp";
            colPhp.ReadOnly = true;
            colPhp.Resizable = DataGridViewTriState.False;
            // 
            // btnDel
            // 
            btnDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnDel.FillWeight = 152.788452F;
            btnDel.HeaderText = "Delete";
            btnDel.Name = "btnDel";
            btnDel.ReadOnly = true;
            btnDel.Resizable = DataGridViewTriState.False;
            btnDel.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDel.Width = 84;
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1272, 854);
            Controls.Add(transactionList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionHistory";
            Text = "TransactionHistory";
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private Panel panel2;
        private Components.CustomComboBox cmbFilter;
        private Components.CustomComboBox cmbOrder;
        private test.textBox.RjButton btnPrint;
        private DataGridView transactionList;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colClient;
        private DataGridViewTextBoxColumn colDnT;
        private DataGridViewTextBoxColumn colAct;
        private DataGridViewTextBoxColumn colPhp;
        private DataGridViewButtonColumn btnDel;
    }
}