namespace DXTreme.Popup
{
    partial class returningtosignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returningtosignUp));
            panel1 = new test.panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pnlLoading = new Panel();
            loading = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.BorderRadius = 0;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Black;
            panel1.GradientAngle = 90F;
            panel1.GradientBottomColor = Color.Red;
            panel1.GradientTopColor = Color.Red;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 88);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(101, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 3;
            label1.Text = "Logging out...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 41);
            label2.Name = "label2";
            label2.Size = new Size(309, 20);
            label2.TabIndex = 4;
            label2.Text = "You will be redirected to the login shortly.";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlLoading);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 10);
            panel2.TabIndex = 5;
            // 
            // pnlLoading
            // 
            pnlLoading.AutoScroll = true;
            pnlLoading.BackColor = Color.Red;
            pnlLoading.Location = new Point(0, 1);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(106, 10);
            pnlLoading.TabIndex = 0;
            // 
            // loading
            // 
            loading.Interval = 18;
            loading.Tick += loading_Tick;
            // 
            // returningtosignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(446, 88);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "returningtosignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "returningtosignUp";
            Load += returningtosignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private test.panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel pnlLoading;
        private System.Windows.Forms.Timer loading;
    }
}