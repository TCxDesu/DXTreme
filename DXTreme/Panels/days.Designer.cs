namespace DXTreme.Frames
{
    partial class days
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlClick = new Panel();
            checkBox1 = new CheckBox();
            lblNumber = new Label();
            pnlClick.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClick
            // 
            pnlClick.Controls.Add(checkBox1);
            pnlClick.Controls.Add(lblNumber);
            pnlClick.Dock = DockStyle.Fill;
            pnlClick.Location = new Point(1, 1);
            pnlClick.Name = "pnlClick";
            pnlClick.Size = new Size(211, 108);
            pnlClick.TabIndex = 0;
            pnlClick.Click += pnlClick_Click;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(16, 26);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(174, -1);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(37, 30);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "00";
            // 
            // days
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlClick);
            Name = "days";
            Padding = new Padding(1);
            Size = new Size(213, 110);
            Load += days_Load;
            pnlClick.ResumeLayout(false);
            pnlClick.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClick;
        private CheckBox checkBox1;
        private Label lblNumber;
    }
}
