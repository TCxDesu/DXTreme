namespace DXTreme.Popup
{
    partial class failed
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
            panel1 = new Panel();
            panel2 = new Panel();
            pnlLoading = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblType = new Label();
            loading = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 60);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlLoading);
            panel2.Location = new Point(9, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 10);
            panel2.TabIndex = 1;
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.Red;
            pnlLoading.Location = new Point(-2, 3);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(71, 10);
            pnlLoading.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.error;
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "FAILED";
            // 
            // lblType
            // 
            lblType.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblType.Location = new Point(76, 27);
            lblType.Name = "lblType";
            lblType.Size = new Size(286, 17);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // loading
            // 
            loading.Interval = 45;
            loading.Tick += loading_Tick;
            // 
            // failed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 60);
            Controls.Add(lblType);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "failed";
            Text = "succes";
            Load += failed_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlLoading;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblType;
        private System.Windows.Forms.Timer loading;
    }
}