namespace DXTreme.Popup
{
    partial class equipment
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
            panel1 = new Panel();
            panel2 = new Panel();
            cmbEquip = new Components.CustomComboBox();
            btnAdd = new test.textBox.RjButton();
            txtBranch = new CustomControls.RJControls.RJTextBox();
            customComboBox1 = new Components.CustomComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            cmbBranch = new test.textBox.RJComboBox();
            btnConfirm = new Components.CustomButton();
            btnCancel = new Components.CustomButton();
            txtDate = new CustomControls.RJControls.RJTextBox();
            txtTime = new CustomControls.RJControls.RJTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 530);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(txtTime);
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(cmbEquip);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtBranch);
            panel2.Controls.Add(customComboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(cmbBranch);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 519);
            panel2.TabIndex = 0;
            // 
            // cmbEquip
            // 
            cmbEquip.BackColor = Color.AliceBlue;
            cmbEquip.BorderColor = Color.Navy;
            cmbEquip.BorderSize = 2;
            cmbEquip.DropDownStyle = ComboBoxStyle.DropDown;
            cmbEquip.Font = new Font("Segoe UI", 10F);
            cmbEquip.ForeColor = Color.DimGray;
            cmbEquip.IconColor = Color.Navy;
            cmbEquip.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbEquip.ListTextColor = Color.DimGray;
            cmbEquip.Location = new Point(80, 136);
            cmbEquip.MinimumSize = new Size(200, 30);
            cmbEquip.Name = "cmbEquip";
            cmbEquip.Padding = new Padding(2);
            cmbEquip.Size = new Size(310, 30);
            cmbEquip.TabIndex = 26;
            cmbEquip.Texts = "Select Equipment";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Black;
            btnAdd.BackgroundColor = Color.Black;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.Add1;
            btnAdd.Location = new Point(396, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 48);
            btnAdd.TabIndex = 25;
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBranch
            // 
            txtBranch.BackColor = SystemColors.Window;
            txtBranch.BorderColor = Color.Navy;
            txtBranch.BorderFocusColor = Color.Navy;
            txtBranch.BorderSize = 2;
            txtBranch.isReadOnly = true;
            txtBranch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBranch.ForeColor = Color.DimGray;
            txtBranch.Location = new Point(80, 374);
            txtBranch.Margin = new Padding(4);
            txtBranch.Multiline = false;
            txtBranch.Name = "txtBranch";
            txtBranch.Padding = new Padding(7);
            txtBranch.PasswordChar = false;
            txtBranch.PlaceholderColor = Color.DarkGray;
            txtBranch.PlaceholderText = "Branch";
            txtBranch.Size = new Size(310, 31);
            txtBranch.TabIndex = 24;
            txtBranch.Texts = "";
            txtBranch.UnderlinedStyle = false;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.AliceBlue;
            customComboBox1.BorderColor = Color.Navy;
            customComboBox1.BorderSize = 2;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox1.Font = new Font("Segoe UI", 10F);
            customComboBox1.ForeColor = Color.DimGray;
            customComboBox1.IconColor = Color.Navy;
            customComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox1.ListTextColor = Color.DimGray;
            customComboBox1.Location = new Point(80, 213);
            customComboBox1.MinimumSize = new Size(200, 30);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(2);
            customComboBox1.Size = new Size(310, 30);
            customComboBox1.TabIndex = 23;
            customComboBox1.Texts = "Slightly, moderately, or heavily damaged";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 355);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 21;
            label4.Text = "Branch";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 273);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 20;
            label3.Text = "Date and Time";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 195);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 19;
            label2.Text = "Condition";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 118);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 18;
            label5.Text = "Name of Equipment";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(168, 68);
            label1.Name = "label1";
            label1.Size = new Size(139, 44);
            label1.TabIndex = 1;
            label1.Text = "Equipment ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 50);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // cmbBranch
            // 
            cmbBranch.BackColor = Color.AliceBlue;
            cmbBranch.BorderColor = Color.Navy;
            cmbBranch.BorderSize = 2;
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBranch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbBranch.ForeColor = Color.DimGray;
            cmbBranch.IconColor = Color.Navy;
            cmbBranch.Items.AddRange(new object[] { "DXtreme Fitness Gym - Mabolo Branch", "DXtreme Fitness Gym - Pitpitan Branch" });
            cmbBranch.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbBranch.ListTextColor = Color.Black;
            cmbBranch.Location = new Point(80, 374);
            cmbBranch.MinimumSize = new Size(200, 30);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Padding = new Padding(2);
            cmbBranch.Size = new Size(310, 38);
            cmbBranch.TabIndex = 27;
            cmbBranch.Texts = "Select a Branch";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Honeydew;
            btnConfirm.BackgroundColor = Color.Honeydew;
            btnConfirm.BorderColor = Color.SeaGreen;
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderSize = 1;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Image = Properties.Resources.check;
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(84, 445);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 38);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.Black;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MistyRose;
            btnCancel.BackgroundColor = Color.MistyRose;
            btnCancel.BorderColor = Color.IndianRed;
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 1;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(238, 445);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(149, 38);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Window;
            txtDate.BorderColor = Color.Navy;
            txtDate.BorderFocusColor = Color.Navy;
            txtDate.BorderSize = 2;
            txtDate.isReadOnly = true;
            txtDate.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.ForeColor = Color.DimGray;
            txtDate.Location = new Point(80, 292);
            txtDate.Margin = new Padding(4);
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.Padding = new Padding(7);
            txtDate.PasswordChar = false;
            txtDate.PlaceholderColor = Color.DarkGray;
            txtDate.PlaceholderText = "MMMM/dd/yyyy";
            txtDate.Size = new Size(187, 31);
            txtDate.TabIndex = 28;
            txtDate.Texts = "";
            txtDate.UnderlinedStyle = false;
            // 
            // txtTime
            // 
            txtTime.BackColor = SystemColors.Window;
            txtTime.BorderColor = Color.Navy;
            txtTime.BorderFocusColor = Color.Navy;
            txtTime.BorderSize = 2;
            txtTime.isReadOnly = true;
            txtTime.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.ForeColor = Color.DimGray;
            txtTime.Location = new Point(275, 292);
            txtTime.Margin = new Padding(4);
            txtTime.Multiline = false;
            txtTime.Name = "txtTime";
            txtTime.Padding = new Padding(7);
            txtTime.PasswordChar = false;
            txtTime.PlaceholderColor = Color.DarkGray;
            txtTime.PlaceholderText = "HH:mm";
            txtTime.Size = new Size(115, 31);
            txtTime.TabIndex = 29;
            txtTime.Texts = "";
            txtTime.UnderlinedStyle = false;
            // 
            // equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(470, 535);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "equipment";
            Load += equipment_Load;
            Shown += equipment_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Components.CustomComboBox customComboBox1;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
        private CustomControls.RJControls.RJTextBox txtBranch;
        private test.textBox.RjButton btnAdd;
        private Components.CustomComboBox cmbEquip;
        private test.textBox.RJComboBox cmbBranch;
        private CustomControls.RJControls.RJTextBox txtDate;
        private CustomControls.RJControls.RJTextBox txtTime;
    }
}