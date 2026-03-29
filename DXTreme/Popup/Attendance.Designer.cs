namespace DXTreme.Popup
{
    partial class attendace
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
            customBorderedTextBox1 = new DXTreme.Components.CustomBorderedTextBox();
            label6 = new Label();
            label4 = new Label();
            rbtnMember = new DXTreme.Components.CustomRadioButton();
            rbtnWalkin = new DXTreme.Components.CustomRadioButton();
            btnConfirm = new DXTreme.Components.CustomButton();
            btnCancel = new DXTreme.Components.CustomButton();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            cmbBranch = new DXTreme.Components.CustomComboBox();
            txtTime = new test.textBox.textBox();
            txtDate = new test.textBox.textBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            customComboBox1 = new DXTreme.Components.CustomComboBox();
            txtName = new test.textBox.textBox();
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
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 515);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(customBorderedTextBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rbtnMember);
            panel2.Controls.Add(rbtnWalkin);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbBranch);
            panel2.Controls.Add(txtTime);
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(customComboBox1);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 498);
            panel2.TabIndex = 0;
            // 
            // customBorderedTextBox1
            // 
            customBorderedTextBox1.BackColor = SystemColors.Window;
            customBorderedTextBox1.BorderColor = Color.Navy;
            customBorderedTextBox1.BorderFocusColor = Color.HotPink;
            customBorderedTextBox1.BorderSize = 2;
            customBorderedTextBox1.Editable = false;
            customBorderedTextBox1.Location = new Point(79, 397);
            customBorderedTextBox1.Multiline = false;
            customBorderedTextBox1.Name = "customBorderedTextBox1";
            customBorderedTextBox1.Padding = new Padding(7);
            customBorderedTextBox1.PasswordChar = false;
            customBorderedTextBox1.Size = new Size(116, 30);
            customBorderedTextBox1.TabIndex = 31;
            customBorderedTextBox1.Texts = "";
            customBorderedTextBox1.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 412);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 30;
            label6.Text = "Price";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 266);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 27;
            label4.Text = "Attendance Type";
            // 
            // rbtnMember
            // 
            rbtnMember.AutoSize = true;
            rbtnMember.CheckedColor = Color.Maroon;
            rbtnMember.Font = new Font("Segoe UI", 12F);
            rbtnMember.Location = new Point(41, 315);
            rbtnMember.MinimumSize = new Size(0, 21);
            rbtnMember.Name = "rbtnMember";
            rbtnMember.Padding = new Padding(10, 0, 0, 0);
            rbtnMember.Size = new Size(97, 25);
            rbtnMember.TabIndex = 26;
            rbtnMember.TabStop = true;
            rbtnMember.Text = "Member";
            rbtnMember.UnCheckedColor = Color.Gray;
            rbtnMember.UseVisualStyleBackColor = true;
            // 
            // rbtnWalkin
            // 
            rbtnWalkin.AutoSize = true;
            rbtnWalkin.CheckedColor = Color.Maroon;
            rbtnWalkin.Font = new Font("Segoe UI", 12F);
            rbtnWalkin.Location = new Point(41, 284);
            rbtnWalkin.MinimumSize = new Size(0, 21);
            rbtnWalkin.Name = "rbtnWalkin";
            rbtnWalkin.Padding = new Padding(10, 0, 0, 0);
            rbtnWalkin.Size = new Size(91, 25);
            rbtnWalkin.TabIndex = 25;
            rbtnWalkin.TabStop = true;
            rbtnWalkin.Text = "Walk-in";
            rbtnWalkin.UnCheckedColor = Color.Gray;
            rbtnWalkin.UseVisualStyleBackColor = true;
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
            btnConfirm.Location = new Point(26, 447);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 38);
            btnConfirm.TabIndex = 24;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.Black;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
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
            btnCancel.Location = new Point(180, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 38);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 204);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 22;
            label3.Text = "Branch";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 141);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 21;
            label2.Text = "Date and Time";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 80);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 20;
            label5.Text = "Name";
            // 
            // cmbBranch
            // 
            cmbBranch.BackColor = Color.AliceBlue;
            cmbBranch.BorderColor = Color.Navy;
            cmbBranch.BorderSize = 2;
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBranch.Font = new Font("Segoe UI", 10F);
            cmbBranch.ForeColor = Color.DimGray;
            cmbBranch.IconColor = Color.Navy;
            cmbBranch.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbBranch.ListTextColor = Color.DimGray;
            cmbBranch.Location = new Point(41, 222);
            cmbBranch.MinimumSize = new Size(200, 30);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Padding = new Padding(2);
            cmbBranch.Size = new Size(200, 30);
            cmbBranch.TabIndex = 19;
            cmbBranch.Texts = "";
            // 
            // txtTime
            // 
            txtTime.BackColor = SystemColors.Window;
            txtTime.BorderColor = Color.Navy;
            txtTime.BorderFocusColor = Color.HotPink;
            txtTime.BorderRadius = 0;
            txtTime.BorderSize = 2;
            txtTime.Editable = false;
            txtTime.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtTime.ForeColor = Color.DimGray;
            txtTime.Location = new Point(203, 160);
            txtTime.Margin = new Padding(4);
            txtTime.Multiline = false;
            txtTime.Name = "txtTime";
            txtTime.Padding = new Padding(10, 7, 10, 7);
            txtTime.PasswordChar = false;
            txtTime.PlaceholderColor = Color.DarkGray;
            txtTime.PlaceholderText = "";
            txtTime.Size = new Size(88, 31);
            txtTime.TabIndex = 18;
            txtTime.Texts = "";
            txtTime.UnderlinedStyle = false;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Window;
            txtDate.BorderColor = Color.Navy;
            txtDate.BorderFocusColor = Color.HotPink;
            txtDate.BorderRadius = 0;
            txtDate.BorderSize = 2;
            txtDate.Editable = false;
            txtDate.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtDate.ForeColor = Color.DimGray;
            txtDate.Location = new Point(41, 160);
            txtDate.Margin = new Padding(4);
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.Padding = new Padding(10, 7, 10, 7);
            txtDate.PasswordChar = false;
            txtDate.PlaceholderColor = Color.DarkGray;
            txtDate.PlaceholderText = "";
            txtDate.Size = new Size(154, 31);
            txtDate.TabIndex = 17;
            txtDate.Texts = "";
            txtDate.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(106, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "Attendance";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 33);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo5;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
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
            customComboBox1.Location = new Point(41, 100);
            customComboBox1.MinimumSize = new Size(200, 30);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(2);
            customComboBox1.Size = new Size(250, 30);
            customComboBox1.TabIndex = 28;
            customComboBox1.Texts = "";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderColor = Color.FromArgb(64, 64, 64);
            txtName.BorderFocusColor = Color.Navy;
            txtName.BorderRadius = 0;
            txtName.BorderSize = 2;
            txtName.Editable = false;
            txtName.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(41, 100);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 7, 10, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "";
            txtName.Size = new Size(250, 31);
            txtName.TabIndex = 16;
            txtName.Texts = "";
            txtName.UnderlinedStyle = true;
            // 
            // attendace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(360, 525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "attendace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "attendace";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Components.CustomComboBox cmbBranch;
        private test.textBox.textBox txtTime;
        private test.textBox.textBox txtDate;
        private test.textBox.textBox txtName;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
        private Components.CustomRadioButton rbtnMember;
        private Components.CustomRadioButton rbtnWalkin;
        private Label label4;
        private Components.CustomComboBox customComboBox1;
        private Label label6;
        private Components.CustomBorderedTextBox customBorderedTextBox1;
    }
}