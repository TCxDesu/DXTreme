namespace DXTreme.Panels
{
    partial class HomePage
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
            lblMonth = new Label();
            lblClock = new Label();
            Clock = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lblMonth
            // 
            lblMonth.BackColor = Color.Transparent;
            lblMonth.Dock = DockStyle.Bottom;
            lblMonth.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.White;
            lblMonth.Location = new Point(0, 615);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(1363, 353);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "MM/DD//YYYY";
            lblMonth.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblClock
            // 
            lblClock.BackColor = Color.Transparent;
            lblClock.Dock = DockStyle.Bottom;
            lblClock.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClock.ForeColor = Color.White;
            lblClock.ImageAlign = ContentAlignment.MiddleLeft;
            lblClock.Location = new Point(0, 540);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(1363, 75);
            lblClock.TabIndex = 5;
            lblClock.Text = "00:00 AA";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clock
            // 
            Clock.Tick += Clock_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1363, 10);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Image = Properties.Resources.Logo_no_bg3;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(1363, 654);
            label1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 968);
            panel2.Name = "panel2";
            panel2.Size = new Size(1363, 10);
            panel2.TabIndex = 8;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1363, 978);
            Controls.Add(lblClock);
            Controls.Add(lblMonth);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblMonth;
        private Label lblClock;
        private System.Windows.Forms.Timer Clock;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}