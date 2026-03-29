namespace DXTreme.Panels
{
    partial class Equipment
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
            btnPrint = new test.textBox.RjButton();
            btnAdd = new test.textBox.RjButton();
            cmbFilter = new Components.CustomComboBox();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            listofequipment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            btnDone = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listofequipment).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 88);
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
            btnPrint.Location = new Point(1165, 21);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(82, 59);
            btnPrint.TabIndex = 9;
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.BackgroundColor = Color.MidnightBlue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.Add1;
            btnAdd.Location = new Point(962, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 59);
            btnAdd.TabIndex = 8;
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            cmbFilter.Location = new Point(617, 31);
            cmbFilter.MinimumSize = new Size(200, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Padding = new Padding(1);
            cmbFilter.Size = new Size(299, 43);
            cmbFilter.TabIndex = 7;
            cmbFilter.Texts = "TYPE";
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
            pnlSearch.Location = new Point(99, 15);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(71, 65);
            pnlSearch.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(224, 224, 224);
            txtSearch.BorderColor = Color.FromArgb(64, 64, 64);
            txtSearch.BorderFocusColor = Color.Blue;
            txtSearch.BorderRadius = 0;
            txtSearch.BorderSize = 2;
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
            btnSearch.BorderColor = Color.RoyalBlue;
            btnSearch.BorderRadius = 30;
            btnSearch.BorderSize = 1;
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
            panel2.Size = new Size(1259, 10);
            panel2.TabIndex = 5;
            // 
            // listofequipment
            // 
            listofequipment.AllowUserToAddRows = false;
            listofequipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listofequipment.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listofequipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listofequipment.ColumnHeadersHeight = 50;
            listofequipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            listofequipment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, btnDone, Column7 });
            listofequipment.Dock = DockStyle.Fill;
            listofequipment.Location = new Point(0, 88);
            listofequipment.MultiSelect = false;
            listofequipment.Name = "listofequipment";
            listofequipment.ReadOnly = true;
            listofequipment.RowHeadersVisible = false;
            listofequipment.Size = new Size(1259, 792);
            listofequipment.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.FillWeight = 74.0708F;
            Column1.HeaderText = "Equipment";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 74.0708F;
            Column2.HeaderText = "Date & Time";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 74.0708F;
            Column3.HeaderText = "Condition";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 74.0708F;
            Column4.HeaderText = "Status";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.FillWeight = 177.664978F;
            Column6.HeaderText = "Edit";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Edit";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 48;
            // 
            // btnDone
            // 
            btnDone.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnDone.FillWeight = 151.940109F;
            btnDone.HeaderText = "Done";
            btnDone.Name = "btnDone";
            btnDone.ReadOnly = true;
            btnDone.Resizable = DataGridViewTriState.True;
            btnDone.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDone.Width = 76;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Maroon;
            Column7.DefaultCellStyle = dataGridViewCellStyle3;
            Column7.FillWeight = 87.05584F;
            Column7.HeaderText = "Delete";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Delete";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 65;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1259, 880);
            Controls.Add(listofequipment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Equipment";
            Text = "Equipment";
            Load += Equipment_Load;
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listofequipment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private Components.CustomComboBox cmbFilter;
        private test.textBox.RjButton btnAdd;
        private test.textBox.RjButton btnPrint;
        private DataGridView listofequipment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn btnDone;
        private DataGridViewButtonColumn Column7;
    }
}