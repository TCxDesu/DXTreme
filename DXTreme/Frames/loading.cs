using DXTreme;
using DXTreme.Frames;

namespace loading
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 8;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
