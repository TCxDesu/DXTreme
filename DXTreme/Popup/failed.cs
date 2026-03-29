using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXTreme.Popup
{
    public partial class failed : Form
    {
        private int toastX, toastY;

        public failed(string type, string message)
        {
            InitializeComponent();
            lblType.Text = message;

            switch (type)
            {
                case "Admin":
                    break;
                case "Member":
                    break;
                case "Equipment":
                    break;
                case "Attendance":
                    break;
            }

            
        }

        private void failed_Load(object sender, EventArgs e)
        {
            position();
            loading.Start();
        }

        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = ScreenWidth - this.Width;
            toastY = ScreenHeight - this.Height;

            this.Location = new Point(toastX, toastY);
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            pnlLoading.Width += 8;
            if (pnlLoading.Width >= 362)
            {
                this.Dispose();
            }
        }
    }
}
