namespace DXTreme.Panels
{
    partial class Archive
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            rjButton1 = new test.textBox.RjButton();
            btnPrint = new test.textBox.RjButton();
            customComboBox2 = new Components.CustomComboBox();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            archiveList = new DataGridView();
            colRefName = new DataGridViewTextBoxColumn();
            colRefTable = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            btnRestore = new DataGridViewButtonColumn();
            btnDel = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)archiveList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(customComboBox2);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 88);
            panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjButton1.BackColor = Color.MidnightBlue;
            rjButton1.BackgroundColor = Color.MidnightBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.Red;
            rjButton1.Image = Properties.Resources.deleteall;
            rjButton1.Location = new Point(1033, 17);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(83, 64);
            rjButton1.TabIndex = 12;
            rjButton1.Text = "DELETE ALL";
            rjButton1.TextColor = Color.Red;
            rjButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            rjButton1.UseVisualStyleBackColor = false;
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
            btnPrint.Location = new Point(1144, 17);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 64);
            btnPrint.TabIndex = 11;
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // customComboBox2
            // 
            customComboBox2.Anchor = AnchorStyles.Right;
            customComboBox2.BackColor = Color.WhiteSmoke;
            customComboBox2.BorderColor = Color.Maroon;
            customComboBox2.BorderSize = 1;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            customComboBox2.ForeColor = Color.Black;
            customComboBox2.IconColor = Color.Maroon;
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(108, 29);
            customComboBox2.MinimumSize = new Size(200, 30);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(299, 43);
            customComboBox2.TabIndex = 10;
            customComboBox2.Texts = "DATE";
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
            pnlSearch.Location = new Point(74, 16);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(71, 65);
            pnlSearch.TabIndex = 7;
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
            btnSearch.Image = Properties.Resources.search3;
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
            panel2.Size = new Size(1257, 10);
            panel2.TabIndex = 6;
            // 
            // archiveList
            // 
            archiveList.AllowUserToAddRows = false;
            archiveList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            archiveList.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            archiveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            archiveList.ColumnHeadersHeight = 50;
            archiveList.Columns.AddRange(new DataGridViewColumn[] { colRefName, colRefTable, colDate, btnRestore, btnDel });
            archiveList.Dock = DockStyle.Fill;
            archiveList.Location = new Point(0, 88);
            archiveList.Name = "archiveList";
            archiveList.RowHeadersVisible = false;
            archiveList.Size = new Size(1257, 787);
            archiveList.TabIndex = 2;
            archiveList.CellClick += archiveList_CellClick;
            archiveList.CellPainting += archiveList_CellPainting;
            // 
            // colRefName
            // 
            colRefName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            colRefName.DefaultCellStyle = dataGridViewCellStyle2;
            colRefName.FillWeight = 87.05584F;
            colRefName.HeaderText = "Name";
            colRefName.Name = "colRefName";
            // 
            // colRefTable
            // 
            colRefTable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRefTable.FillWeight = 87.05584F;
            colRefTable.HeaderText = "Table";
            colRefTable.Name = "colRefTable";
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDate.FillWeight = 87.05584F;
            colDate.HeaderText = "Date of Archive";
            colDate.Name = "colDate";
            // 
            // btnRestore
            // 
            btnRestore.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnRestore.HeaderText = "Restore";
            btnRestore.Name = "btnRestore";
            btnRestore.ReadOnly = true;
            btnRestore.Width = 74;
            // 
            // btnDel
            // 
            btnDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Maroon;
            btnDel.DefaultCellStyle = dataGridViewCellStyle3;
            btnDel.FillWeight = 87.05584F;
            btnDel.HeaderText = "Delete";
            btnDel.Name = "btnDel";
            btnDel.Text = "";
            btnDel.UseColumnTextForButtonValue = true;
            btnDel.Width = 65;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1257, 875);
            Controls.Add(archiveList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Archive";
            Text = "Archive";
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)archiveList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private Components.CustomComboBox customComboBox2;
        private test.textBox.RjButton btnPrint;
        private DataGridView archiveList;
        private test.textBox.RjButton rjButton1;
        private DataGridViewTextBoxColumn colRefName;
        private DataGridViewTextBoxColumn colRefTable;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewButtonColumn btnRestore;
        private DataGridViewButtonColumn btnDel;
    }
}