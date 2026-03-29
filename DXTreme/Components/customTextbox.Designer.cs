namespace DXTreme
{
    partial class customTextbox
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            labelTimer = new System.Windows.Forms.Timer(components);
            textBox1 = new Components.CustomBorderedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "Text";
            // 
            // labelTimer
            // 
            labelTimer.Interval = 1;
            labelTimer.Tick += labelTimer_Tick;
            // 
            // textBox1
            // 
            textBox1.BorderColor = Color.Crimson;
            textBox1.BorderFocusColor = Color.Black;
            textBox1.BorderSize = 2;
            textBox1.Location = new Point(3, 17);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(341, 35);
            textBox1.TabIndex = 2;
            textBox1.Texts = "";
            textBox1.UnderlinedStyle = true;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // customTextbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "customTextbox";
            Size = new Size(347, 59);
            Load += customTextbox_Load;
            Paint += customTextbox_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer labelTimer;
        private Components.CustomBorderedTextBox textBox1;
    }
}
