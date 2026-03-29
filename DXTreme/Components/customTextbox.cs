using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXTreme
{
    public partial class customTextbox : UserControl
    {
        public customTextbox()
        {
            InitializeComponent();
        }

        bool isFocused = false;
        private string text = "";
        private bool pass = false;
        private bool multiline = false;

        private Color backColor = Color.White;
        private Color foreColor = Color.Black;

        
        public bool password
        {
            get { return pass; }
            set
            {
                pass = value;
                this.Invalidate();
            }
        }
        public bool customMultiLine
        {
            get { return multiline; }
            set
            {
                multiline = value;
                this.Invalidate();
            }
        }
        public string customText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }
        public Color customBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                this.Invalidate();
            }
        }
        public Color customForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                this.Invalidate();
            }
        }
        private void customTextbox_Load(object sender, EventArgs e)
        {
            if (pass == true)
            {
                textBox1.PasswordChar = true;
            }
        }
        private void customTextbox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = customText;
            if (customMultiLine == true)
            {
                textBox1.Multiline = true;
                textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                textBox1.Height = this.Height;
            }
            this.BackColor = customBackColor;
            label1.BackColor = customBackColor;
            textBox1.BackColor = customBackColor;

            textBox1.ForeColor = customForeColor;
        }
        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;

            if (isFocused == false)
            {

                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 2)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;

                }
            }
            else
            {

                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 25)
                {
                    isFocused = false;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 10);
                    y = 25;
                    label1.ForeColor = Color.Black;

                }
            }
        }
        public string GetText = "";
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Texts.Trim() == "")
            {
                labelTimer.Start();
                textBox1.Texts = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Texts.Trim() == "")
            {
                labelTimer.Start();
                textBox1.Texts = "";
            }
            GetText = textBox1.Texts;
        }
    }
}
