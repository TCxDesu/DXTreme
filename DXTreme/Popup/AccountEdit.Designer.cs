namespace DXTreme.Popup
{
    partial class AccountEdit
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
            txtAccType = new CustomControls.RJControls.RJTextBox();
            txtBranch = new CustomControls.RJControls.RJTextBox();
            btnChangeType = new Components.CustomButton();
            btnChangeBranch = new Components.CustomButton();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            txtUsername = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            btnChangeUser = new Components.CustomButton();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnConfirm = new Components.CustomButton();
            btnCancel = new Components.CustomButton();
            btnChangePass = new Components.CustomButton();
            btnProfile = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            cmbBranch = new test.textBox.RJComboBox();
            cmbType = new test.textBox.RJComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnProfile).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 433);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(txtAccType);
            panel2.Controls.Add(txtBranch);
            panel2.Controls.Add(btnChangeType);
            panel2.Controls.Add(btnChangeBranch);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnChangeUser);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnChangePass);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(cmbBranch);
            panel2.Controls.Add(cmbType);
            panel2.Location = new Point(14, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 412);
            panel2.TabIndex = 0;
            // 
            // txtAccType
            // 
            txtAccType.BackColor = SystemColors.Window;
            txtAccType.BorderColor = Color.Navy;
            txtAccType.BorderFocusColor = Color.Navy;
            txtAccType.BorderSize = 2;
            txtAccType.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccType.ForeColor = Color.DimGray;
            txtAccType.isReadOnly = true;
            txtAccType.Location = new Point(291, 293);
            txtAccType.Margin = new Padding(4);
            txtAccType.Multiline = false;
            txtAccType.Name = "txtAccType";
            txtAccType.Padding = new Padding(7);
            txtAccType.PasswordChar = false;
            txtAccType.PlaceholderColor = Color.DarkGray;
            txtAccType.PlaceholderText = "";
            txtAccType.Size = new Size(342, 31);
            txtAccType.TabIndex = 33;
            txtAccType.Texts = "";
            txtAccType.UnderlinedStyle = false;
            // 
            // txtBranch
            // 
            txtBranch.BackColor = SystemColors.Window;
            txtBranch.BorderColor = Color.Navy;
            txtBranch.BorderFocusColor = Color.Navy;
            txtBranch.BorderSize = 2;
            txtBranch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBranch.ForeColor = Color.DimGray;
            txtBranch.isReadOnly = true;
            txtBranch.Location = new Point(291, 220);
            txtBranch.Margin = new Padding(4);
            txtBranch.Multiline = false;
            txtBranch.Name = "txtBranch";
            txtBranch.Padding = new Padding(7);
            txtBranch.PasswordChar = false;
            txtBranch.PlaceholderColor = Color.DarkGray;
            txtBranch.PlaceholderText = "";
            txtBranch.Size = new Size(342, 31);
            txtBranch.TabIndex = 32;
            txtBranch.Texts = "";
            txtBranch.UnderlinedStyle = false;
            // 
            // btnChangeType
            // 
            btnChangeType.BackColor = Color.Navy;
            btnChangeType.BackgroundColor = Color.Navy;
            btnChangeType.BorderColor = Color.PaleVioletRed;
            btnChangeType.BorderRadius = 10;
            btnChangeType.BorderSize = 0;
            btnChangeType.FlatAppearance.BorderSize = 0;
            btnChangeType.FlatStyle = FlatStyle.Flat;
            btnChangeType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangeType.ForeColor = Color.White;
            btnChangeType.Location = new Point(640, 294);
            btnChangeType.Name = "btnChangeType";
            btnChangeType.Size = new Size(117, 31);
            btnChangeType.TabIndex = 29;
            btnChangeType.Text = "Change";
            btnChangeType.TextColor = Color.White;
            btnChangeType.UseVisualStyleBackColor = false;
            btnChangeType.Click += btnChangeType_Click;
            // 
            // btnChangeBranch
            // 
            btnChangeBranch.BackColor = Color.Navy;
            btnChangeBranch.BackgroundColor = Color.Navy;
            btnChangeBranch.BorderColor = Color.PaleVioletRed;
            btnChangeBranch.BorderRadius = 10;
            btnChangeBranch.BorderSize = 0;
            btnChangeBranch.FlatAppearance.BorderSize = 0;
            btnChangeBranch.FlatStyle = FlatStyle.Flat;
            btnChangeBranch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangeBranch.ForeColor = Color.White;
            btnChangeBranch.Location = new Point(640, 221);
            btnChangeBranch.Name = "btnChangeBranch";
            btnChangeBranch.Size = new Size(117, 31);
            btnChangeBranch.TabIndex = 28;
            btnChangeBranch.Text = "Change";
            btnChangeBranch.TextColor = Color.White;
            btnChangeBranch.UseVisualStyleBackColor = false;
            btnChangeBranch.Click += btnChangeBranch_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.Navy;
            txtPassword.BorderFocusColor = Color.Navy;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.isReadOnly = true;
            txtPassword.Location = new Point(291, 151);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "";
            txtPassword.Size = new Size(342, 31);
            txtPassword.TabIndex = 25;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.Navy;
            txtUsername.BorderFocusColor = Color.Navy;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.isReadOnly = true;
            txtUsername.Location = new Point(291, 87);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "";
            txtUsername.Size = new Size(342, 31);
            txtUsername.TabIndex = 24;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 272);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 23;
            label2.Text = "Account Type";
            // 
            // btnChangeUser
            // 
            btnChangeUser.BackColor = Color.Navy;
            btnChangeUser.BackgroundColor = Color.Navy;
            btnChangeUser.BorderColor = Color.PaleVioletRed;
            btnChangeUser.BorderRadius = 10;
            btnChangeUser.BorderSize = 0;
            btnChangeUser.FlatAppearance.BorderSize = 0;
            btnChangeUser.FlatStyle = FlatStyle.Flat;
            btnChangeUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangeUser.ForeColor = Color.White;
            btnChangeUser.Location = new Point(640, 87);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(117, 31);
            btnChangeUser.TabIndex = 21;
            btnChangeUser.Text = "Change";
            btnChangeUser.TextColor = Color.White;
            btnChangeUser.UseVisualStyleBackColor = false;
            btnChangeUser.Click += btnChangeUser_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 199);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 20;
            label4.Text = "Branch";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 132);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 19;
            label3.Text = "Password ";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 68);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 18;
            label5.Text = "Username";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.AliceBlue;
            btnConfirm.BackgroundColor = Color.AliceBlue;
            btnConfirm.BorderColor = Color.SeaGreen;
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderSize = 3;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Image = Properties.Resources.check;
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(371, 347);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 40);
            btnConfirm.TabIndex = 15;
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
            btnCancel.BorderColor = Color.Maroon;
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 3;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(544, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.Navy;
            btnChangePass.BackgroundColor = Color.Navy;
            btnChangePass.BorderColor = Color.PaleVioletRed;
            btnChangePass.BorderRadius = 10;
            btnChangePass.BorderSize = 0;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(640, 151);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(117, 31);
            btnChangePass.TabIndex = 6;
            btnChangePass.Text = "Change";
            btnChangePass.TextColor = Color.White;
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Image = Properties.Resources.profilepic;
            btnProfile.Location = new Point(9, 95);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(259, 227);
            btnProfile.SizeMode = PictureBoxSizeMode.Zoom;
            btnProfile.TabIndex = 1;
            btnProfile.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 35);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 1;
            label1.Text = "Account Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            cmbBranch.Location = new Point(291, 218);
            cmbBranch.MinimumSize = new Size(200, 30);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Padding = new Padding(2);
            cmbBranch.Size = new Size(342, 38);
            cmbBranch.TabIndex = 30;
            cmbBranch.Texts = "Select a Branch";
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
            cmbType.Items.AddRange(new object[] { "Staff Account", "Manager Account" });
            cmbType.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbType.ListTextColor = Color.Black;
            cmbType.Location = new Point(291, 291);
            cmbType.MinimumSize = new Size(200, 30);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(2);
            cmbType.Size = new Size(342, 38);
            cmbType.TabIndex = 31;
            cmbType.Texts = "Select a Role";
            // 
            // AccountEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(810, 440);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccounSettings";
            Load += AccounSettings_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnProfile).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Components.CustomButton btnChangePass;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
        private Label label5;
        private Label label3;
        private Label label4;
        private PictureBox btnProfile;
        private Components.CustomButton btnChangeUser;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJTextBox txtUsername;
        private Components.CustomButton btnChangeType;
        private Components.CustomButton btnChangeBranch;
        private CustomControls.RJControls.RJTextBox txtAccType;
        private CustomControls.RJControls.RJTextBox txtBranch;
        private test.textBox.RJComboBox cmbBranch;
        private test.textBox.RJComboBox cmbType;
    }
}