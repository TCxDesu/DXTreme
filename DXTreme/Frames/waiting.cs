using DXTreme;
using DXTreme.Frames;

public partial class waiting : Form
{
    public waiting()
    {
        InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        panel2.Width += 8;
        if (panel2.Width >= 800)
        {
            timer1.Stop();
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
