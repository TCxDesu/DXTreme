namespace DXTreme.Panels
{
    partial class ActiveMembers
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
            cmbDate = new Components.CustomComboBox();
            cmbMemberShip = new Components.CustomComboBox();
            btnPrint = new test.textBox.RjButton();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            listofmember = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listofmember).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(cmbDate);
            panel1.Controls.Add(cmbMemberShip);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 88);
            panel1.TabIndex = 0;
            // 
            // cmbDate
            // 
            cmbDate.Anchor = AnchorStyles.Right;
            cmbDate.BackColor = Color.WhiteSmoke;
            cmbDate.BorderColor = Color.Maroon;
            cmbDate.BorderSize = 1;
            cmbDate.DropDownStyle = ComboBoxStyle.DropDown;
            cmbDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDate.ForeColor = Color.Black;
            cmbDate.IconColor = Color.Maroon;
            cmbDate.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbDate.ListTextColor = Color.DimGray;
            cmbDate.Location = new Point(462, 29);
            cmbDate.MinimumSize = new Size(200, 30);
            cmbDate.Name = "cmbDate";
            cmbDate.Padding = new Padding(1);
            cmbDate.Size = new Size(299, 43);
            cmbDate.TabIndex = 9;
            cmbDate.Texts = "DATE";
            // 
            // cmbMemberShip
            // 
            cmbMemberShip.Anchor = AnchorStyles.Right;
            cmbMemberShip.BackColor = Color.WhiteSmoke;
            cmbMemberShip.BorderColor = Color.Maroon;
            cmbMemberShip.BorderSize = 1;
            cmbMemberShip.DropDownStyle = ComboBoxStyle.DropDown;
            cmbMemberShip.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMemberShip.ForeColor = Color.Black;
            cmbMemberShip.IconColor = Color.Maroon;
            cmbMemberShip.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbMemberShip.ListTextColor = Color.DimGray;
            cmbMemberShip.Location = new Point(141, 29);
            cmbMemberShip.MinimumSize = new Size(200, 30);
            cmbMemberShip.Name = "cmbMemberShip";
            cmbMemberShip.Padding = new Padding(1);
            cmbMemberShip.Size = new Size(299, 43);
            cmbMemberShip.TabIndex = 8;
            cmbMemberShip.Texts = "MEMBERSHIP TYPE";
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
            btnPrint.Location = new Point(1146, 16);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 64);
            btnPrint.TabIndex = 7;
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
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
            pnlSearch.Location = new Point(80, 16);
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
            txtSearch.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panel2.Size = new Size(1259, 10);
            panel2.TabIndex = 5;
            // 
            // listofmember
            // 
            listofmember.AllowUserToAddRows = false;
            listofmember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listofmember.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listofmember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listofmember.ColumnHeadersHeight = 50;
            listofmember.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, status, Column6, Column7 });
            listofmember.Dock = DockStyle.Fill;
            listofmember.Location = new Point(0, 88);
            listofmember.Name = "listofmember";
            listofmember.RowHeadersVisible = false;
            listofmember.Size = new Size(1259, 790);
            listofmember.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.FillWeight = 87.05584F;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 87.05584F;
            Column2.HeaderText = "Membership Type";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 87.05584F;
            Column4.HeaderText = "Date of Membership";
            Column4.Name = "Column4";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.FillWeight = 177.664978F;
            Column6.HeaderText = "Edit";
            Column6.Name = "Column6";
            Column6.Text = "Edit";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 48;
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
            Column7.Text = "Delete";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 65;
            // 
            // ActiveMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1259, 878);
            Controls.Add(listofmember);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActiveMembers";
            Text = "ActiveMembers";
            Load += ActiveMembers_Load;
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listofmember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private test.textBox.RjButton btnPrint;
        private DataGridView listofmember;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Components.CustomComboBox cmbMemberShip;
        private Components.CustomComboBox cmbDate;
    }
}