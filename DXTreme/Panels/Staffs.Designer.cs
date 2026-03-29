namespace DXTreme.Panels
{
    partial class Staffs
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
            cmbBrances = new Components.CustomComboBox();
            btnPrint = new test.textBox.RjButton();
            pnlSearch = new test.panel();
            txtSearch = new test.textBox.textBox();
            btnSearch = new test.textBox.RjButton();
            panel2 = new Panel();
            listofstaff = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            branch = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listofstaff).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(cmbBrances);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1625, 88);
            panel1.TabIndex = 0;
            // 
            // cmbBrances
            // 
            cmbBrances.Anchor = AnchorStyles.Right;
            cmbBrances.BackColor = Color.WhiteSmoke;
            cmbBrances.BorderColor = Color.Maroon;
            cmbBrances.BorderSize = 1;
            cmbBrances.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBrances.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbBrances.ForeColor = Color.Black;
            cmbBrances.IconColor = Color.Maroon;
            cmbBrances.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbBrances.ListTextColor = Color.DimGray;
            cmbBrances.Location = new Point(514, 29);
            cmbBrances.MinimumSize = new Size(200, 30);
            cmbBrances.Name = "cmbBrances";
            cmbBrances.Padding = new Padding(1);
            cmbBrances.Size = new Size(299, 43);
            cmbBrances.TabIndex = 11;
            cmbBrances.Texts = "BRANCES";
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
            btnPrint.Location = new Point(1531, 19);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(82, 59);
            btnPrint.TabIndex = 10;
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
            pnlSearch.Location = new Point(76, 16);
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
            panel2.Size = new Size(1625, 10);
            panel2.TabIndex = 5;
            // 
            // listofstaff
            // 
            listofstaff.AllowUserToAddRows = false;
            listofstaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listofstaff.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listofstaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listofstaff.ColumnHeadersHeight = 50;
            listofstaff.Columns.AddRange(new DataGridViewColumn[] { name, branch, status, btnEdit, btnDelete });
            listofstaff.Dock = DockStyle.Fill;
            listofstaff.Location = new Point(0, 88);
            listofstaff.Name = "listofstaff";
            listofstaff.RowHeadersVisible = false;
            listofstaff.Size = new Size(1625, 786);
            listofstaff.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 87.05584F;
            name.HeaderText = "Username of Staff";
            name.Name = "name";
            // 
            // branch
            // 
            branch.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            branch.DefaultCellStyle = dataGridViewCellStyle2;
            branch.FillWeight = 87.05584F;
            branch.HeaderText = "Branch";
            branch.Name = "branch";
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.FillWeight = 87.05584F;
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnEdit.FillWeight = 177.664978F;
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
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
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 65;
            // 
            // Staffs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1625, 874);
            Controls.Add(listofstaff);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staffs";
            Text = "Stuff";
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listofstaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private test.panel pnlSearch;
        private test.textBox.textBox txtSearch;
        private test.textBox.RjButton btnSearch;
        private test.textBox.RjButton btnPrint;
        private Components.CustomComboBox cmbBrances;
        private DataGridView listofstaff;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn branch;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}