using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXTreme.Panels
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblMonth.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Clock.Start();
        }
    }
}
