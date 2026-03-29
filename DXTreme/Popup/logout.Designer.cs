namespace DXTreme.Popup
{
    partial class logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logout));
            panel1 = new test.panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnConfirm = new DXTreme.Components.CustomButton();
            btnCancel = new DXTreme.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderRadius = 0;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Black;
            panel1.GradientAngle = 90F;
            panel1.GradientBottomColor = Color.Maroon;
            panel1.GradientTopColor = Color.Maroon;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 94);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 2;
            label1.Text = "Log Out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 32);
            label2.Name = "label2";
            label2.Size = new Size(263, 21);
            label2.TabIndex = 3;
            label2.Text = "Are you sure to log out?\", \"Log out";
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
            btnConfirm.Location = new Point(359, 62);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(106, 31);
            btnConfirm.TabIndex = 17;
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
            btnCancel.Location = new Point(471, 63);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 31);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // logout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 94);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "logout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private test.panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
    }
}