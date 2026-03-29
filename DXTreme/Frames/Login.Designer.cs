namespace DXTreme
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblClose = new Label();
            pnlDrag = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblWrongUserName = new Label();
            lblWrongPassword = new Label();
            lblPassword = new Label();
            lblUser = new Label();
            btnOpen = new test.textBox.RjButton();
            btnClose = new test.textBox.RjButton();
            txtUsername = new test.textBox.textBox();
            btnEnter = new test.textBox.RjButton();
            txtPassword = new test.textBox.textBox();
            pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblClose
            // 
            lblClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClose.AutoSize = true;
            lblClose.BackColor = Color.Black;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.Maroon;
            lblClose.Location = new Point(950, -3);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(38, 41);
            lblClose.TabIndex = 0;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // pnlDrag
            // 
            pnlDrag.BackColor = Color.Black;
            pnlDrag.Controls.Add(label2);
            pnlDrag.Controls.Add(lblClose);
            pnlDrag.Dock = DockStyle.Top;
            pnlDrag.Location = new Point(0, 0);
            pnlDrag.Margin = new Padding(3, 2, 3, 2);
            pnlDrag.Name = "pnlDrag";
            pnlDrag.Size = new Size(988, 38);
            pnlDrag.TabIndex = 5;
            pnlDrag.MouseDown += pnlDrag_MouseDown;
            pnlDrag.MouseMove += pnlDrag_MouseMove;
            pnlDrag.MouseUp += pnlDrag_MouseUp;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 1;
            label2.Text = "GYM SYSTEM MANAGEMENT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(694, 88);
            label1.Name = "label1";
            label1.Size = new Size(224, 75);
            label1.TabIndex = 11;
            label1.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Person_Icon1;
            pictureBox1.Location = new Point(32, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.Lock1;
            pictureBox3.Location = new Point(32, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.Logo_no_bg;
            pictureBox2.Location = new Point(62, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(536, 437);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblWrongUserName);
            panel1.Controls.Add(lblWrongPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnEnter);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(636, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 301);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // lblWrongUserName
            // 
            lblWrongUserName.ForeColor = Color.Red;
            lblWrongUserName.Location = new Point(73, 89);
            lblWrongUserName.Name = "lblWrongUserName";
            lblWrongUserName.Size = new Size(210, 23);
            lblWrongUserName.TabIndex = 26;
            lblWrongUserName.Text = "*Wrong UserName";
            lblWrongUserName.Visible = false;
            // 
            // lblWrongPassword
            // 
            lblWrongPassword.ForeColor = Color.Red;
            lblWrongPassword.Location = new Point(72, 157);
            lblWrongPassword.Name = "lblWrongPassword";
            lblWrongPassword.Size = new Size(210, 23);
            lblWrongPassword.TabIndex = 25;
            lblWrongPassword.Text = "*Wrong Password";
            lblWrongPassword.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.Image = Properties.Resources.error;
            lblPassword.Location = new Point(32, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(33, 31);
            lblPassword.TabIndex = 24;
            lblPassword.Visible = false;
            // 
            // lblUser
            // 
            lblUser.Image = Properties.Resources.error;
            lblUser.Location = new Point(32, 53);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(32, 31);
            lblUser.TabIndex = 23;
            lblUser.Visible = false;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.White;
            btnOpen.BackgroundColor = Color.White;
            btnOpen.BorderColor = Color.PaleVioletRed;
            btnOpen.BorderRadius = 0;
            btnOpen.BorderSize = 0;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.ForeColor = Color.White;
            btnOpen.Image = Properties.Resources.open;
            btnOpen.Location = new Point(252, 118);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(31, 29);
            btnOpen.TabIndex = 21;
            btnOpen.TextColor = Color.White;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.BackgroundColor = Color.White;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 0;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(252, 118);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 20;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.FromArgb(64, 64, 64);
            txtUsername.BorderFocusColor = Color.Maroon;
            txtUsername.BorderRadius = 0;
            txtUsername.BorderSize = 5;
            txtUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(71, 53);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(10, 7, 10, 7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(211, 32);
            txtUsername.TabIndex = 0;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = true;
            txtUsername.KeyPress += Login_KeyPress;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.BackgroundColor = Color.Black;
            btnEnter.BorderColor = Color.Maroon;
            btnEnter.BorderRadius = 10;
            btnEnter.BorderSize = 1;
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.White;
            btnEnter.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnter.Location = new Point(71, 192);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(211, 51);
            btnEnter.TabIndex = 19;
            btnEnter.Tag = "";
            btnEnter.Text = "Enter";
            btnEnter.TextColor = Color.White;
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnHome_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(64, 64, 64);
            txtPassword.BorderFocusColor = Color.Maroon;
            txtPassword.BorderRadius = 0;
            txtPassword.BorderSize = 5;
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(71, 118);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(181, 32);
            txtPassword.TabIndex = 27;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Login_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 563);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pnlDrag);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            Shown += Login_Shown;
            KeyDown += Login_KeyDown;
            KeyPress += Login_KeyPress;
            pnlDrag.ResumeLayout(false);
            pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClose;
        private Panel pnlDrag;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private test.textBox.RjButton btnEnter;
        private test.textBox.RjButton btnClose;
        private test.textBox.RjButton btnOpen;
        private Label lblUser;
        private Label lblPassword;
        private Label lblWrongUserName;
        private Label lblWrongPassword;
        private Label label2;
        private test.textBox.textBox txtUsername;
        private test.textBox.textBox txtPassword;
    }
}
