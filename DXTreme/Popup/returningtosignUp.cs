using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.Frames;

namespace DXTreme.Popup
{
    public partial class returningtosignUp : Form
    {
        private int toastX, toastY;
        private Form formToClose;
        public returningtosignUp(Form formToClose)
        {
            InitializeComponent();
            this.formToClose = formToClose;
        }
        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = ScreenWidth - this.Width - 15;
            toastY = ScreenHeight - this.Height + 10;

            this.Location = new Point(toastX, toastY);
        }


        private void returningtosignUp_Load(object sender, EventArgs e)
        {
            position();
            loading.Start();
        }

        private void loading_Tick(object sender, EventArgs e)
        {

            pnlLoading.Width += 8;
            if (pnlLoading.Width >= 436)
            {
                loading.Stop();

                if (formToClose != null && !formToClose.IsDisposed)
                {
                    formToClose.Close();
                }

                Login loginForm = new Login();
                loginForm.Show();

                this.Dispose();
            }
        }
    }
}
