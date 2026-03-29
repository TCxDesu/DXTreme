namespace DXTreme.Panels
{
    partial class DataLog
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
            tblLog = new DataGridView();
            panel1 = new Panel();
            btnPrint = new test.textBox.RjButton();
            cmbFilter = new Components.CustomComboBox();
            cmbOrder = new Components.CustomComboBox();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            colID = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewTextBoxColumn();
            colAct = new DataGridViewTextBoxColumn();
            colDnT = new DataGridViewTextBoxColumn();
            btnDel = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tblLog).BeginInit();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // tblLog
            // 
            tblLog.AllowUserToAddRows = false;
            tblLog.AllowUserToResizeColumns = false;
            tblLog.AllowUserToResizeRows = false;
            tblLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblLog.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblLog.Columns.AddRange(new DataGridViewColumn[] { colID, colStaff, colAct, colDnT, btnDel });
            tblLog.Dock = DockStyle.Bottom;
            tblLog.Location = new Point(0, 93);
            tblLog.Margin = new Padding(3, 2, 3, 2);
            tblLog.Name = "tblLog";
            tblLog.RowHeadersVisible = false;
            tblLog.RowHeadersWidth = 51;
            tblLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblLog.Size = new Size(1264, 896);
            tblLog.TabIndex = 17;
            tblLog.CellClick += tblLog_CellClick;
            tblLog.CellPainting += tblLog_CellPainting;
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
            panel1.Size = new Size(1264, 88);
            panel1.TabIndex = 18;
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
            btnPrint.Location = new Point(1151, 16);
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
            cmbFilter.Location = new Point(122, 29);
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
            cmbOrder.Location = new Point(451, 29);
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
            pnlSearch.Location = new Point(83, 16);
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
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 10);
            panel2.TabIndex = 1;
            // 
            // colID
            // 
            colID.HeaderText = "Data Log ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Resizable = DataGridViewTriState.False;
            colID.Visible = false;
            // 
            // colStaff
            // 
            colStaff.HeaderText = "Staff";
            colStaff.MinimumWidth = 6;
            colStaff.Name = "colStaff";
            colStaff.ReadOnly = true;
            colStaff.Resizable = DataGridViewTriState.False;
            // 
            // colAct
            // 
            colAct.HeaderText = "Activity";
            colAct.MinimumWidth = 6;
            colAct.Name = "colAct";
            colAct.ReadOnly = true;
            // 
            // colDnT
            // 
            colDnT.HeaderText = "Date and Time";
            colDnT.MinimumWidth = 6;
            colDnT.Name = "colDnT";
            colDnT.ReadOnly = true;
            // 
            // btnDel
            // 
            btnDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnDel.HeaderText = "Delete";
            btnDel.Name = "btnDel";
            btnDel.ReadOnly = true;
            btnDel.Resizable = DataGridViewTriState.False;
            btnDel.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDel.Width = 84;
            // 
            // DataLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1264, 989);
            Controls.Add(panel1);
            Controls.Add(tblLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataLog";
            Text = "DataLog2";
            ((System.ComponentModel.ISupportInitialize)tblLog).EndInit();
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblLog;
        private Panel panel1;
        private Panel panel2;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private Components.CustomComboBox cmbFilter;
        private Components.CustomComboBox cmbOrder;
        private test.textBox.RjButton btnPrint;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colStaff;
        private DataGridViewTextBoxColumn colAct;
        private DataGridViewTextBoxColumn colDnT;
        private DataGridViewButtonColumn btnDel;
    }
}