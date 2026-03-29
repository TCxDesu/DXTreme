namespace DXTreme.Popup
{
    partial class addadminaccount
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
            label6 = new Label();
            cmbType = new test.textBox.RJComboBox();
            btnConfirm = new DXTreme.Components.CustomButton();
            btnCancel = new DXTreme.Components.CustomButton();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbBranch = new test.textBox.RJComboBox();
            txtPasswordConfir = new test.textBox.textBox();
            txtPassword = new test.textBox.textBox();
            txtName = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 558);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbBranch);
            panel2.Controls.Add(txtPasswordConfir);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 546);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 315);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 21;
            label6.Text = "Account Type";
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.AliceBlue;
            cmbType.BorderColor = Color.Navy;
            cmbType.BorderSize = 2;
            cmbType.DropDownStyle = ComboBoxStyle.DropDown;
            cmbType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbType.ForeColor = Color.DimGray;
            cmbType.IconColor = Color.Navy;
            cmbType.Items.AddRange(new object[] { "Manager" });
            cmbType.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbType.ListTextColor = Color.Black;
            cmbType.Location = new Point(58, 333);
            cmbType.MinimumSize = new Size(200, 30);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(2);
            cmbType.Size = new Size(299, 38);
            cmbType.TabIndex = 20;
            cmbType.Texts = "Select a Role";
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
            btnConfirm.Location = new Point(59, 484);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 38);
            btnConfirm.TabIndex = 19;
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
            btnCancel.Location = new Point(212, 484);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 38);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 105);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 17;
            label5.Text = "User Name";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 177);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 16;
            label3.Text = "Password ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 249);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 15;
            label2.Text = "Password Confirmation";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 394);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 14;
            label4.Text = "Branch";
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
            cmbBranch.Location = new Point(58, 412);
            cmbBranch.MinimumSize = new Size(200, 30);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Padding = new Padding(2);
            cmbBranch.Size = new Size(299, 38);
            cmbBranch.TabIndex = 5;
            cmbBranch.Texts = "Select a Branch";
            // 
            // txtPasswordConfir
            // 
            txtPasswordConfir.BackColor = SystemColors.Window;
            txtPasswordConfir.BorderColor = Color.FromArgb(64, 64, 64);
            txtPasswordConfir.BorderFocusColor = Color.Navy;
            txtPasswordConfir.BorderRadius = 0;
            txtPasswordConfir.BorderSize = 2;
            txtPasswordConfir.Editable = false;
            txtPasswordConfir.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtPasswordConfir.ForeColor = Color.DimGray;
            txtPasswordConfir.Location = new Point(58, 268);
            txtPasswordConfir.Margin = new Padding(4);
            txtPasswordConfir.Multiline = false;
            txtPasswordConfir.Name = "txtPasswordConfir";
            txtPasswordConfir.Padding = new Padding(10, 7, 10, 7);
            txtPasswordConfir.PasswordChar = true;
            txtPasswordConfir.PlaceholderColor = Color.DarkGray;
            txtPasswordConfir.PlaceholderText = "Password Confirmation";
            txtPasswordConfir.Size = new Size(299, 31);
            txtPasswordConfir.TabIndex = 4;
            txtPasswordConfir.Texts = "";
            txtPasswordConfir.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(64, 64, 64);
            txtPassword.BorderFocusColor = Color.Navy;
            txtPassword.BorderRadius = 0;
            txtPassword.BorderSize = 2;
            txtPassword.Editable = false;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(58, 196);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(299, 31);
            txtPassword.TabIndex = 3;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.FromArgb(64, 64, 64);
            txtName.BorderFocusColor = Color.Navy;
            txtName.BorderSize = 2;
            txtName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.isReadOnly = false;
            txtName.Location = new Point(58, 124);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "User Name";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 2;
            txtName.Texts = "";
            txtName.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(153, 42);
            label1.Name = "label1";
            label1.Size = new Size(122, 43);
            label1.TabIndex = 1;
            label1.Text = "Add Staff";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 39);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo5;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // addadminaccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(421, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addadminaccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addadminaccount";
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
        private test.textBox.RJComboBox cmbBranch;
        private test.textBox.textBox txtPasswordConfir;
        private test.textBox.textBox txtPassword;
        private CustomControls.RJControls.RJTextBox txtName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
        private test.textBox.RJComboBox cmbType;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
    }
}