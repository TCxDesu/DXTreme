namespace DXTreme.Frames
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            pnlMenu = new Panel();
            btnAtten = new test.textBox.RjButton();
            btnEquip = new test.textBox.RjButton();
            btnMembers = new test.textBox.RjButton();
            sidepanel = new test.panel();
            btnHome = new test.textBox.RjButton();
            panel4 = new Panel();
            btnMenuDown = new test.textBox.RjButton();
            btnMenu = new test.textBox.RjButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTitle = new Label();
            btnAccount = new PictureBox();
            pnlShow = new Panel();
            container = new Panel();
            btnSettings = new Components.CustomButton();
            btnLogout = new Components.CustomButton();
            pnlMenu.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccount).BeginInit();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Black;
            pnlMenu.Controls.Add(btnAtten);
            pnlMenu.Controls.Add(btnEquip);
            pnlMenu.Controls.Add(btnMembers);
            pnlMenu.Controls.Add(sidepanel);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(panel4);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(223, 825);
            pnlMenu.TabIndex = 0;
            // 
            // btnAtten
            // 
            btnAtten.BackColor = Color.Black;
            btnAtten.BackgroundColor = Color.Black;
            btnAtten.BorderColor = Color.Maroon;
            btnAtten.BorderRadius = 0;
            btnAtten.BorderSize = 1;
            btnAtten.Cursor = Cursors.Hand;
            btnAtten.FlatAppearance.BorderSize = 0;
            btnAtten.FlatStyle = FlatStyle.Flat;
            btnAtten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAtten.ForeColor = Color.White;
            btnAtten.Image = Properties.Resources.attendance;
            btnAtten.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtten.Location = new Point(15, 691);
            btnAtten.Name = "btnAtten";
            btnAtten.Size = new Size(205, 110);
            btnAtten.TabIndex = 9;
            btnAtten.Tag = "Attendance";
            btnAtten.Text = "  Attendance";
            btnAtten.TextColor = Color.White;
            btnAtten.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtten.UseVisualStyleBackColor = false;
            btnAtten.Click += rjButton1_Click;
            // 
            // btnEquip
            // 
            btnEquip.BackColor = Color.Black;
            btnEquip.BackgroundColor = Color.Black;
            btnEquip.BorderColor = Color.Maroon;
            btnEquip.BorderRadius = 0;
            btnEquip.BorderSize = 1;
            btnEquip.Cursor = Cursors.Hand;
            btnEquip.FlatAppearance.BorderSize = 0;
            btnEquip.FlatStyle = FlatStyle.Flat;
            btnEquip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEquip.ForeColor = Color.White;
            btnEquip.Image = Properties.Resources.Equipment;
            btnEquip.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquip.Location = new Point(15, 542);
            btnEquip.Name = "btnEquip";
            btnEquip.Size = new Size(205, 110);
            btnEquip.TabIndex = 8;
            btnEquip.Tag = "Equipment Condition";
            btnEquip.Text = "  Equipment Condition";
            btnEquip.TextColor = Color.White;
            btnEquip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEquip.UseVisualStyleBackColor = false;
            btnEquip.Click += btnEquip_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.Black;
            btnMembers.BackgroundColor = Color.Black;
            btnMembers.BorderColor = Color.Maroon;
            btnMembers.BorderRadius = 0;
            btnMembers.BorderSize = 1;
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMembers.ForeColor = Color.White;
            btnMembers.Image = Properties.Resources.Members;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(15, 389);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(205, 110);
            btnMembers.TabIndex = 7;
            btnMembers.Tag = "List of Members";
            btnMembers.Text = " List of Members";
            btnMembers.TextColor = Color.White;
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.White;
            sidepanel.BorderRadius = 0;
            sidepanel.ForeColor = Color.Black;
            sidepanel.GradientAngle = 100F;
            sidepanel.GradientBottomColor = Color.Maroon;
            sidepanel.GradientTopColor = Color.Maroon;
            sidepanel.Location = new Point(3, 238);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(10, 110);
            sidepanel.TabIndex = 5;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.BackgroundColor = Color.Black;
            btnHome.BorderColor = Color.Maroon;
            btnHome.BorderRadius = 0;
            btnHome.BorderSize = 1;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.House1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(15, 238);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(205, 110);
            btnHome.TabIndex = 6;
            btnHome.Tag = "Home";
            btnHome.Text = "  Home";
            btnHome.TextColor = Color.White;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMenuDown);
            panel4.Controls.Add(btnMenu);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 104);
            panel4.TabIndex = 0;
            // 
            // btnMenuDown
            // 
            btnMenuDown.BackColor = Color.Black;
            btnMenuDown.BackgroundColor = Color.Black;
            btnMenuDown.BorderColor = Color.White;
            btnMenuDown.BorderRadius = 0;
            btnMenuDown.BorderSize = 1;
            btnMenuDown.Cursor = Cursors.Hand;
            btnMenuDown.Dock = DockStyle.Right;
            btnMenuDown.FlatAppearance.BorderSize = 0;
            btnMenuDown.FlatStyle = FlatStyle.Flat;
            btnMenuDown.ForeColor = Color.White;
            btnMenuDown.Image = Properties.Resources._3down2;
            btnMenuDown.Location = new Point(127, 0);
            btnMenuDown.Name = "btnMenuDown";
            btnMenuDown.Size = new Size(48, 104);
            btnMenuDown.TabIndex = 5;
            btnMenuDown.Tag = "";
            btnMenuDown.TextColor = Color.White;
            btnMenuDown.UseVisualStyleBackColor = false;
            btnMenuDown.Click += btnMenuDown_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Black;
            btnMenu.BackgroundColor = Color.Black;
            btnMenu.BorderColor = Color.White;
            btnMenu.BorderRadius = 0;
            btnMenu.BorderSize = 1;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Right;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources._3_Line;
            btnMenu.Location = new Point(175, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(48, 104);
            btnMenu.TabIndex = 3;
            btnMenu.Tag = "";
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Visible = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(container);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(btnAccount);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(223, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 104);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(6, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 42);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "STAFF DASHBOARD";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAccount
            // 
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Dock = DockStyle.Right;
            btnAccount.Image = Properties.Resources.Person_Icon2;
            btnAccount.Location = new Point(913, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(98, 104);
            btnAccount.SizeMode = PictureBoxSizeMode.Zoom;
            btnAccount.TabIndex = 2;
            btnAccount.TabStop = false;
            btnAccount.Click += pictureBox2_Click;
            // 
            // pnlShow
            // 
            pnlShow.BackColor = Color.FromArgb(32, 32, 32);
            pnlShow.Dock = DockStyle.Fill;
            pnlShow.Location = new Point(223, 104);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(1011, 721);
            pnlShow.TabIndex = 2;
            // 
            // container
            // 
            container.Controls.Add(btnSettings);
            container.Controls.Add(btnLogout);
            container.Dock = DockStyle.Right;
            container.Location = new Point(626, 0);
            container.Name = "container";
            container.Size = new Size(287, 104);
            container.TabIndex = 30;
            container.Visible = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.LightGray;
            btnSettings.BackgroundColor = Color.LightGray;
            btnSettings.BorderColor = Color.PaleVioletRed;
            btnSettings.BorderRadius = 20;
            btnSettings.BorderSize = 0;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 46);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(134, 52);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Account";
            btnSettings.TextColor = Color.Black;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightGray;
            btnLogout.BackgroundColor = Color.LightGray;
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 20;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(143, 46);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 52);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.FromArgb(192, 0, 0);
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 825);
            Controls.Add(pnlShow);
            Controls.Add(panel2);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            FormClosing += Staff_FormClosing;
            pnlMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAccount).EndInit();
            container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel panel2;
        private Panel pnlShow;
        private Panel panel4;
        private test.textBox.RjButton btnMenu;
        private PictureBox pictureBox1;
        private test.textBox.RjButton btnAtten;
        private test.textBox.RjButton btnEquip;
        private test.textBox.RjButton btnMembers;
        private test.panel sidepanel;
        private test.textBox.RjButton btnHome;
        private PictureBox btnAccount;
        private Label lblTitle;
        private test.textBox.RjButton btnMenuDown;
        private Panel container;
        private Components.CustomButton btnSettings;
        private Components.CustomButton btnLogout;
    }
}