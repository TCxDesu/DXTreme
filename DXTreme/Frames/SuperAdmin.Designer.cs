namespace DXTreme.Frames
{
    partial class SuperAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin));
            pnlDrop = new Panel();
            btnListUp = new test.textBox.RjButton();
            btnListDown = new test.textBox.RjButton();
            btnActiveM = new test.textBox.RjButton();
            btnAdmins = new test.textBox.RjButton();
            btnMembers = new test.textBox.RjButton();
            btnArc = new test.textBox.RjButton();
            btnTrans = new test.textBox.RjButton();
            btnEquip = new test.textBox.RjButton();
            btnHome = new test.textBox.RjButton();
            pnlDashboard = new Panel();
            btnMenuDown = new test.textBox.RjButton();
            btnMenu = new test.textBox.RjButton();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            container = new Panel();
            btnSettings = new Components.CustomButton();
            btnLogout = new Components.CustomButton();
            panel1 = new Panel();
            btnAccount = new PictureBox();
            lblTitle = new Label();
            pnlShow = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAtten = new test.textBox.RjButton();
            btnDatalog = new test.textBox.RjButton();
            pnlMenu = new Panel();
            pnlDrop.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccount).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDrop
            // 
            pnlDrop.BackColor = Color.Black;
            pnlDrop.Controls.Add(btnListUp);
            pnlDrop.Controls.Add(btnListDown);
            pnlDrop.Controls.Add(btnActiveM);
            pnlDrop.Controls.Add(btnAdmins);
            pnlDrop.Controls.Add(btnMembers);
            pnlDrop.Location = new Point(3, 79);
            pnlDrop.MaximumSize = new Size(205, 303);
            pnlDrop.MinimumSize = new Size(205, 75);
            pnlDrop.Name = "pnlDrop";
            pnlDrop.Size = new Size(205, 75);
            pnlDrop.TabIndex = 7;
            // 
            // btnListUp
            // 
            btnListUp.AutoSize = true;
            btnListUp.BackColor = Color.Black;
            btnListUp.BackgroundColor = Color.Black;
            btnListUp.BorderColor = Color.Maroon;
            btnListUp.BorderRadius = 0;
            btnListUp.BorderSize = 1;
            btnListUp.Cursor = Cursors.Hand;
            btnListUp.FlatAppearance.BorderSize = 0;
            btnListUp.FlatStyle = FlatStyle.Flat;
            btnListUp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnListUp.ForeColor = Color.White;
            btnListUp.Image = Properties.Resources.arrowup1;
            btnListUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnListUp.Location = new Point(0, 0);
            btnListUp.Name = "btnListUp";
            btnListUp.Size = new Size(205, 70);
            btnListUp.TabIndex = 6;
            btnListUp.Tag = "List of Admins";
            btnListUp.Text = "    List";
            btnListUp.TextColor = Color.White;
            btnListUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListUp.UseVisualStyleBackColor = false;
            btnListUp.Click += btnList_Click;
            // 
            // btnListDown
            // 
            btnListDown.BackColor = Color.Black;
            btnListDown.BackgroundColor = Color.Black;
            btnListDown.BorderColor = Color.Maroon;
            btnListDown.BorderRadius = 0;
            btnListDown.BorderSize = 1;
            btnListDown.Cursor = Cursors.Hand;
            btnListDown.Dock = DockStyle.Top;
            btnListDown.FlatAppearance.BorderSize = 0;
            btnListDown.FlatStyle = FlatStyle.Flat;
            btnListDown.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            btnListDown.ForeColor = Color.White;
            btnListDown.Image = Properties.Resources.arrowDown2;
            btnListDown.ImageAlign = ContentAlignment.MiddleLeft;
            btnListDown.Location = new Point(0, 0);
            btnListDown.Name = "btnListDown";
            btnListDown.Size = new Size(205, 70);
            btnListDown.TabIndex = 7;
            btnListDown.Tag = "List of Admins";
            btnListDown.Text = "    List";
            btnListDown.TextColor = Color.White;
            btnListDown.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListDown.UseVisualStyleBackColor = false;
            btnListDown.Click += btnListDown_Click;
            // 
            // btnActiveM
            // 
            btnActiveM.BackColor = Color.FromArgb(20, 33, 36);
            btnActiveM.BackgroundColor = Color.FromArgb(20, 33, 36);
            btnActiveM.BorderColor = Color.Maroon;
            btnActiveM.BorderRadius = 15;
            btnActiveM.BorderSize = 1;
            btnActiveM.Cursor = Cursors.Hand;
            btnActiveM.FlatAppearance.BorderSize = 0;
            btnActiveM.FlatStyle = FlatStyle.Flat;
            btnActiveM.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            btnActiveM.ForeColor = Color.White;
            btnActiveM.Image = Properties.Resources.Active;
            btnActiveM.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveM.Location = new Point(19, 76);
            btnActiveM.Name = "btnActiveM";
            btnActiveM.Size = new Size(173, 70);
            btnActiveM.TabIndex = 5;
            btnActiveM.Tag = "List of Admins";
            btnActiveM.Text = "    Active Member";
            btnActiveM.TextColor = Color.White;
            btnActiveM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiveM.UseVisualStyleBackColor = false;
            btnActiveM.Click += btnActiveM_Click;
            // 
            // btnAdmins
            // 
            btnAdmins.BackColor = Color.FromArgb(20, 33, 36);
            btnAdmins.BackgroundColor = Color.FromArgb(20, 33, 36);
            btnAdmins.BorderColor = Color.Maroon;
            btnAdmins.BorderRadius = 15;
            btnAdmins.BorderSize = 1;
            btnAdmins.Cursor = Cursors.Hand;
            btnAdmins.FlatAppearance.BorderSize = 0;
            btnAdmins.FlatStyle = FlatStyle.Flat;
            btnAdmins.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            btnAdmins.ForeColor = Color.White;
            btnAdmins.Image = Properties.Resources.Admins;
            btnAdmins.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmins.Location = new Point(19, 228);
            btnAdmins.Name = "btnAdmins";
            btnAdmins.Size = new Size(173, 70);
            btnAdmins.TabIndex = 3;
            btnAdmins.Tag = "List of Staffs";
            btnAdmins.Text = "    Staffs";
            btnAdmins.TextColor = Color.White;
            btnAdmins.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmins.UseVisualStyleBackColor = false;
            btnAdmins.Click += btnAdmins_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(20, 33, 36);
            btnMembers.BackgroundColor = Color.FromArgb(20, 33, 36);
            btnMembers.BorderColor = Color.Maroon;
            btnMembers.BorderRadius = 15;
            btnMembers.BorderSize = 1;
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            btnMembers.ForeColor = Color.White;
            btnMembers.Image = Properties.Resources.Members;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(19, 152);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(173, 70);
            btnMembers.TabIndex = 2;
            btnMembers.Tag = "List of Members";
            btnMembers.Text = "    Members";
            btnMembers.TextColor = Color.White;
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnArc
            // 
            btnArc.BackColor = Color.Black;
            btnArc.BackgroundColor = Color.Black;
            btnArc.BorderColor = Color.Maroon;
            btnArc.BorderRadius = 0;
            btnArc.BorderSize = 1;
            btnArc.Cursor = Cursors.Hand;
            btnArc.FlatAppearance.BorderSize = 0;
            btnArc.FlatStyle = FlatStyle.Flat;
            btnArc.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            btnArc.ForeColor = Color.White;
            btnArc.Image = Properties.Resources.icons8_archive_25;
            btnArc.ImageAlign = ContentAlignment.MiddleLeft;
            btnArc.Location = new Point(6, 960);
            btnArc.Name = "btnArc";
            btnArc.Size = new Size(205, 66);
            btnArc.TabIndex = 7;
            btnArc.Tag = "Archive";
            btnArc.Text = "    Archive";
            btnArc.TextAlign = ContentAlignment.MiddleLeft;
            btnArc.TextColor = Color.White;
            btnArc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArc.UseVisualStyleBackColor = false;
            btnArc.Click += rjButton1_Click;
            // 
            // btnTrans
            // 
            btnTrans.BackColor = Color.Black;
            btnTrans.BackgroundColor = Color.Black;
            btnTrans.BorderColor = Color.Maroon;
            btnTrans.BorderRadius = 0;
            btnTrans.BorderSize = 1;
            btnTrans.Cursor = Cursors.Hand;
            btnTrans.FlatAppearance.BorderSize = 0;
            btnTrans.FlatStyle = FlatStyle.Flat;
            btnTrans.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnTrans.ForeColor = Color.White;
            btnTrans.Image = Properties.Resources.Transaction_History;
            btnTrans.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrans.Location = new Point(3, 312);
            btnTrans.Name = "btnTrans";
            btnTrans.Size = new Size(205, 70);
            btnTrans.TabIndex = 6;
            btnTrans.Tag = "Transaction History";
            btnTrans.Text = "    Transaction History";
            btnTrans.TextColor = Color.White;
            btnTrans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrans.UseVisualStyleBackColor = false;
            btnTrans.Click += btnTrans_Click;
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
            btnEquip.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEquip.ForeColor = Color.White;
            btnEquip.Image = Properties.Resources.Equipment;
            btnEquip.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquip.Location = new Point(3, 160);
            btnEquip.Name = "btnEquip";
            btnEquip.Size = new Size(205, 70);
            btnEquip.TabIndex = 4;
            btnEquip.Tag = "Equipment Condition";
            btnEquip.Text = "    Equipment Condition";
            btnEquip.TextColor = Color.White;
            btnEquip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEquip.UseVisualStyleBackColor = false;
            btnEquip.Click += btnEquip_Click;
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
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.House1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(205, 70);
            btnHome.TabIndex = 1;
            btnHome.Tag = "Home";
            btnHome.Text = "    Home";
            btnHome.TextColor = Color.White;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.Black;
            pnlDashboard.Controls.Add(btnMenuDown);
            pnlDashboard.Controls.Add(btnMenu);
            pnlDashboard.Controls.Add(pictureBox1);
            pnlDashboard.Dock = DockStyle.Top;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(223, 104);
            pnlDashboard.TabIndex = 0;
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
            btnMenuDown.Image = Properties.Resources._3down;
            btnMenuDown.Location = new Point(127, 0);
            btnMenuDown.Name = "btnMenuDown";
            btnMenuDown.Size = new Size(48, 104);
            btnMenuDown.TabIndex = 3;
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
            btnMenu.Image = Properties.Resources._3_Line1;
            btnMenu.Location = new Point(175, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(48, 104);
            btnMenu.TabIndex = 2;
            btnMenu.Tag = "";
            btnMenu.TextColor = Color.White;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Visible = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._242187984_430502211834236_686904025810807324_n;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Black;
            panelTitleBar.Controls.Add(container);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(btnAccount);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(223, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1616, 104);
            panelTitleBar.TabIndex = 1;
            // 
            // container
            // 
            container.Controls.Add(btnSettings);
            container.Controls.Add(btnLogout);
            container.Dock = DockStyle.Right;
            container.Location = new Point(1229, 44);
            container.Name = "container";
            container.Size = new Size(289, 60);
            container.TabIndex = 26;
            container.Visible = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.LightSlateGray;
            btnSettings.BackgroundColor = Color.LightSlateGray;
            btnSettings.BorderColor = Color.PaleVioletRed;
            btnSettings.BorderRadius = 20;
            btnSettings.BorderSize = 0;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 4);
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
            btnLogout.BackColor = Color.LightSlateGray;
            btnLogout.BackgroundColor = Color.LightSlateGray;
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 20;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(143, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 52);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.FromArgb(192, 0, 0);
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 44);
            panel1.TabIndex = 25;
            // 
            // btnAccount
            // 
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Dock = DockStyle.Right;
            btnAccount.Image = Properties.Resources.Person_Icon2;
            btnAccount.Location = new Point(1518, 0);
            btnAccount.Margin = new Padding(0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(98, 104);
            btnAccount.SizeMode = PictureBoxSizeMode.Zoom;
            btnAccount.TabIndex = 1;
            btnAccount.TabStop = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(503, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SUPER ADMIN DASHBOARD";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlShow
            // 
            pnlShow.BackColor = Color.FromArgb(32, 32, 32);
            pnlShow.Dock = DockStyle.Fill;
            pnlShow.Location = new Point(223, 104);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(1616, 973);
            pnlShow.TabIndex = 2;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 15;
            menuTransition.Tick += sidebarTransition_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(pnlDrop);
            flowLayoutPanel1.Controls.Add(btnEquip);
            flowLayoutPanel1.Controls.Add(btnAtten);
            flowLayoutPanel1.Controls.Add(btnTrans);
            flowLayoutPanel1.Controls.Add(btnDatalog);
            flowLayoutPanel1.Location = new Point(3, 110);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(217, 841);
            flowLayoutPanel1.TabIndex = 8;
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
            btnAtten.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAtten.ForeColor = Color.White;
            btnAtten.Image = Properties.Resources.attendance;
            btnAtten.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtten.Location = new Point(3, 236);
            btnAtten.Name = "btnAtten";
            btnAtten.Size = new Size(205, 70);
            btnAtten.TabIndex = 15;
            btnAtten.Tag = "Equipment Condition";
            btnAtten.Text = "    Attendance";
            btnAtten.TextColor = Color.White;
            btnAtten.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtten.UseVisualStyleBackColor = false;
            btnAtten.Click += btnAtten_Click;
            // 
            // btnDatalog
            // 
            btnDatalog.BackColor = Color.Black;
            btnDatalog.BackgroundColor = Color.Black;
            btnDatalog.BorderColor = Color.Maroon;
            btnDatalog.BorderRadius = 0;
            btnDatalog.BorderSize = 1;
            btnDatalog.Cursor = Cursors.Hand;
            btnDatalog.FlatAppearance.BorderSize = 0;
            btnDatalog.FlatStyle = FlatStyle.Flat;
            btnDatalog.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDatalog.ForeColor = Color.White;
            btnDatalog.Image = Properties.Resources.Datalog;
            btnDatalog.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatalog.Location = new Point(3, 388);
            btnDatalog.Name = "btnDatalog";
            btnDatalog.Size = new Size(205, 68);
            btnDatalog.TabIndex = 17;
            btnDatalog.Tag = "List of Members";
            btnDatalog.Text = "   Data Log";
            btnDatalog.TextColor = Color.White;
            btnDatalog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDatalog.UseVisualStyleBackColor = false;
            btnDatalog.Click += btnDatalog_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Black;
            pnlMenu.Controls.Add(btnArc);
            pnlMenu.Controls.Add(pnlDashboard);
            pnlMenu.Controls.Add(flowLayoutPanel1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(223, 1077);
            pnlMenu.TabIndex = 0;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1839, 1077);
            Controls.Add(pnlShow);
            Controls.Add(panelTitleBar);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "superAdminFrame_2_";
            WindowState = FormWindowState.Maximized;
            pnlDrop.ResumeLayout(false);
            pnlDrop.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAccount).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitleBar;
        private Panel pnlDashboard;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private test.textBox.RjButton btnHome;
        private test.textBox.RjButton btnTrans;
        private test.textBox.RjButton btnEquip;
        private test.textBox.RjButton btnAdmins;
        private test.textBox.RjButton btnMembers;
        private test.textBox.RjButton btnMenu;
        private test.textBox.RjButton btnArc;
        private PictureBox btnAccount;
        private Panel pnlShow;
        private System.Windows.Forms.Timer menuTransition;
        private test.textBox.RjButton btnActiveM;
        private test.textBox.RjButton btnListUp;
        private Panel pnlDrop;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlMenu;
        private test.textBox.RjButton btnAtten;
        private test.textBox.RjButton btnDatalog;
        private test.textBox.RjButton btnListDown;
        private test.textBox.RjButton btnMenuDown;
        private Components.CustomButton btnSettings;
        private Components.CustomButton btnLogout;
        private Panel container;
        private Panel panel1;
    }
}