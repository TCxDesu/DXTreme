namespace DXTreme.Popup
{
    partial class MemberRegistration
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
            btnConfirm = new DXTreme.Components.CustomButton();
            label2 = new Label();
            btnCancel = new DXTreme.Components.CustomButton();
            txtMI = new CustomControls.RJControls.RJTextBox();
            txtFN = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNumber = new Label();
            label1 = new Label();
            cmbType = new DXTreme.Components.CustomComboBox();
            cmbOptions = new test.textBox.RJComboBox();
            txtLN = new CustomControls.RJControls.RJTextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            customBorderedTextBox1 = new DXTreme.Components.CustomBorderedTextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtMI);
            panel1.Controls.Add(txtFN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(cmbOptions);
            panel1.Controls.Add(txtLN);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(customBorderedTextBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 416);
            panel1.TabIndex = 0;
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
            btnConfirm.Location = new Point(50, 359);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 38);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.Black;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 122);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 16;
            label2.Text = ",";
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
            btnCancel.Location = new Point(203, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 38);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // txtMI
            // 
            txtMI.BackColor = Color.White;
            txtMI.BorderColor = Color.FromArgb(64, 64, 64);
            txtMI.BorderFocusColor = Color.Navy;
            txtMI.BorderSize = 2;
            txtMI.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMI.ForeColor = Color.DimGray;
            txtMI.isReadOnly = false;
            txtMI.Location = new Point(336, 108);
            txtMI.Margin = new Padding(4);
            txtMI.Multiline = false;
            txtMI.Name = "txtMI";
            txtMI.Padding = new Padding(7);
            txtMI.PasswordChar = false;
            txtMI.PlaceholderColor = Color.DarkGray;
            txtMI.PlaceholderText = "M.I.";
            txtMI.Size = new Size(48, 31);
            txtMI.TabIndex = 15;
            txtMI.Texts = "";
            txtMI.UnderlinedStyle = true;
            // 
            // txtFN
            // 
            txtFN.BackColor = Color.White;
            txtFN.BorderColor = Color.FromArgb(64, 64, 64);
            txtFN.BorderFocusColor = Color.Navy;
            txtFN.BorderSize = 2;
            txtFN.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFN.ForeColor = Color.DimGray;
            txtFN.isReadOnly = false;
            txtFN.Location = new Point(170, 108);
            txtFN.Margin = new Padding(4);
            txtFN.Multiline = false;
            txtFN.Name = "txtFN";
            txtFN.Padding = new Padding(7);
            txtFN.PasswordChar = false;
            txtFN.PlaceholderColor = Color.DarkGray;
            txtFN.PlaceholderText = "First Name";
            txtFN.Size = new Size(158, 31);
            txtFN.TabIndex = 14;
            txtFN.Texts = "";
            txtFN.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 89);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 226);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 153);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Options";
            // 
            // lblNumber
            // 
            lblNumber.BackColor = SystemColors.Window;
            lblNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(71, 306);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(109, 27);
            lblNumber.TabIndex = 6;
            lblNumber.Text = "0.00";
            lblNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 37);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 5;
            label1.Text = "Member Registration";
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.AliceBlue;
            cmbType.BorderColor = Color.Navy;
            cmbType.BorderSize = 1;
            cmbType.DropDownStyle = ComboBoxStyle.DropDown;
            cmbType.Font = new Font("Segoe UI", 10F);
            cmbType.ForeColor = Color.DimGray;
            cmbType.IconColor = Color.Navy;
            cmbType.Items.AddRange(new object[] { "Regular", "Senior", "Student" });
            cmbType.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbType.ListTextColor = Color.DimGray;
            cmbType.Location = new Point(28, 244);
            cmbType.MinimumSize = new Size(200, 30);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(1);
            cmbType.Size = new Size(354, 30);
            cmbType.TabIndex = 3;
            cmbType.Texts = "Type of Membership";
            cmbType.OnSelectedIndexChanged += cmbType_OnSelectedIndexChanged;
            // 
            // cmbOptions
            // 
            cmbOptions.BackColor = Color.AliceBlue;
            cmbOptions.BorderColor = Color.Navy;
            cmbOptions.BorderSize = 1;
            cmbOptions.DropDownStyle = ComboBoxStyle.DropDown;
            cmbOptions.Font = new Font("Segoe UI", 10F);
            cmbOptions.ForeColor = Color.DimGray;
            cmbOptions.IconColor = Color.Navy;
            cmbOptions.Items.AddRange(new object[] { "Monthly Membership" });
            cmbOptions.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbOptions.ListTextColor = Color.DimGray;
            cmbOptions.Location = new Point(28, 171);
            cmbOptions.MinimumSize = new Size(200, 30);
            cmbOptions.Name = "cmbOptions";
            cmbOptions.Padding = new Padding(1);
            cmbOptions.Size = new Size(354, 30);
            cmbOptions.TabIndex = 2;
            cmbOptions.Texts = "Choose an Option";
            cmbOptions.OnSelectedIndexChanged += cmbOptions_OnSelectedIndexChanged;
            cmbOptions.Load += cmbOptions_Load;
            // 
            // txtLN
            // 
            txtLN.BackColor = Color.White;
            txtLN.BorderColor = Color.FromArgb(64, 64, 64);
            txtLN.BorderFocusColor = Color.Navy;
            txtLN.BorderSize = 2;
            txtLN.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLN.ForeColor = Color.DimGray;
            txtLN.isReadOnly = false;
            txtLN.Location = new Point(28, 108);
            txtLN.Margin = new Padding(4);
            txtLN.Multiline = false;
            txtLN.Name = "txtLN";
            txtLN.Padding = new Padding(7);
            txtLN.PasswordChar = false;
            txtLN.PlaceholderColor = Color.DarkGray;
            txtLN.PlaceholderText = "Last Name";
            txtLN.Size = new Size(134, 31);
            txtLN.TabIndex = 1;
            txtLN.Texts = "";
            txtLN.UnderlinedStyle = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 34);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo5;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // customBorderedTextBox1
            // 
            customBorderedTextBox1.BorderColor = Color.Navy;
            customBorderedTextBox1.BorderFocusColor = Color.Navy;
            customBorderedTextBox1.BorderSize = 2;
            customBorderedTextBox1.Editable = false;
            customBorderedTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customBorderedTextBox1.Location = new Point(28, 305);
            customBorderedTextBox1.Multiline = false;
            customBorderedTextBox1.Name = "customBorderedTextBox1";
            customBorderedTextBox1.Padding = new Padding(7);
            customBorderedTextBox1.PasswordChar = false;
            customBorderedTextBox1.Size = new Size(154, 32);
            customBorderedTextBox1.TabIndex = 13;
            customBorderedTextBox1.Texts = "Php";
            customBorderedTextBox1.UnderlinedStyle = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(-3, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 423);
            panel3.TabIndex = 1;
            // 
            // MemberRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(406, 427);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberRegistration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Components.CustomComboBox cmbType;
        private test.textBox.RJComboBox cmbOptions;
        private CustomControls.RJControls.RJTextBox txtLN;
        private Label lblNumber;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Components.CustomBorderedTextBox customBorderedTextBox1;
        private CustomControls.RJControls.RJTextBox txtMI;
        private CustomControls.RJControls.RJTextBox txtFN;
        private Components.CustomButton btnConfirm;
        private Label label2;
        private Components.CustomButton btnCancel;
    }
}