namespace DXTreme.Popup
{
    partial class AddEquipmentToList
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
            btnConfirm = new DXTreme.Components.CustomButton();
            btnCancel = new DXTreme.Components.CustomButton();
            label5 = new Label();
            txtName = new test.textBox.textBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 278);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 265);
            panel2.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Honeydew;
            btnConfirm.BackgroundColor = Color.Honeydew;
            btnConfirm.BorderColor = Color.SeaGreen;
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderSize = 1;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Image = Properties.Resources.check;
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(80, 193);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 38);
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
            btnCancel.BorderColor = Color.IndianRed;
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 1;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(238, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(149, 38);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.Black;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 118);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 18;
            label5.Text = "Name of Equipment";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderColor = Color.FromArgb(64, 64, 64);
            txtName.BorderFocusColor = Color.Navy;
            txtName.BorderRadius = 0;
            txtName.BorderSize = 2;
            txtName.Editable = false;
            txtName.Font = new Font("Microsoft Sans Serif", 9.25F);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(77, 137);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 7, 10, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(310, 31);
            txtName.TabIndex = 2;
            txtName.Texts = "";
            txtName.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(168, 68);
            label1.Name = "label1";
            label1.Size = new Size(139, 44);
            label1.TabIndex = 1;
            label1.Text = "Equipment ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 50);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AddEquipmentToList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(470, 283);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEquipmentToList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "equipment";
            Load += AddEquipmentToList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private test.textBox.textBox txtName;
        private Label label5;
        private PictureBox pictureBox1;
        private Components.CustomButton btnConfirm;
        private Components.CustomButton btnCancel;
    }
}