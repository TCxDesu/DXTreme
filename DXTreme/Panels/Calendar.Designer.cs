namespace DXTreme.Frames
{
    partial class Calendar
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
            panel3 = new Panel();
            btnRight = new test.textBox.RjButton();
            btnLeft = new test.textBox.RjButton();
            panel6 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            lblDateAndYear = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1698, 143);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btnRight);
            panel3.Controls.Add(btnLeft);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblDateAndYear);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1698, 143);
            panel3.TabIndex = 1;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(255, 128, 0);
            btnRight.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnRight.BorderColor = Color.Black;
            btnRight.BorderRadius = 10;
            btnRight.BorderSize = 3;
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI Emoji", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRight.ForeColor = Color.Black;
            btnRight.ImageAlign = ContentAlignment.TopCenter;
            btnRight.Location = new Point(1190, 46);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(69, 65);
            btnRight.TabIndex = 1;
            btnRight.Text = ">";
            btnRight.TextAlign = ContentAlignment.TopRight;
            btnRight.TextColor = Color.Black;
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += rjButton1_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(255, 128, 0);
            btnLeft.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnLeft.BorderColor = Color.Black;
            btnLeft.BorderRadius = 10;
            btnLeft.BorderSize = 3;
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI Emoji", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeft.ForeColor = Color.Black;
            btnLeft.Location = new Point(583, 46);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(69, 65);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "<";
            btnLeft.TextAlign = ContentAlignment.TopCenter;
            btnLeft.TextColor = Color.Black;
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(panel2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 138);
            panel6.Name = "panel6";
            panel6.Size = new Size(1698, 5);
            panel6.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(1548, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Maroon;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1698, 5);
            panel5.TabIndex = 3;
            // 
            // lblDateAndYear
            // 
            lblDateAndYear.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateAndYear.ForeColor = Color.White;
            lblDateAndYear.Location = new Point(668, 9);
            lblDateAndYear.Name = "lblDateAndYear";
            lblDateAndYear.Size = new Size(502, 126);
            lblDateAndYear.TabIndex = 2;
            lblDateAndYear.Text = "May 2025";
            lblDateAndYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(116, 226);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1535, 587);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Location = new Point(108, 143);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1589, 80);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 80);
            label1.TabIndex = 0;
            label1.Text = "SUNDAY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(234, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 80);
            label2.TabIndex = 1;
            label2.Text = "MONDAY";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(453, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 80);
            label3.TabIndex = 2;
            label3.Text = "TUESDAY";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(672, 0);
            label4.Name = "label4";
            label4.Size = new Size(213, 80);
            label4.TabIndex = 3;
            label4.Text = "WEDNESDAY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(891, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 80);
            label5.TabIndex = 4;
            label5.Text = "THURSDAY";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1110, 0);
            label6.Name = "label6";
            label6.Size = new Size(213, 80);
            label6.TabIndex = 5;
            label6.Text = "FRIDAY";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1329, 0);
            label7.Name = "label7";
            label7.Size = new Size(213, 80);
            label7.TabIndex = 6;
            label7.Text = "SATURDAY";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 815);
            panel4.Name = "panel4";
            panel4.Size = new Size(1698, 10);
            panel4.TabIndex = 7;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1698, 825);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calendar";
            Load += Calendar_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private test.textBox.RjButton btnLeft;
        private Label lblDateAndYear;
        private test.textBox.RjButton btnRight;
        private Panel panel3;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Panel panel6;
        private Panel panel2;
    }
}