using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.Panels;
using DXTreme.Popup;
using DXTreme.SQL_Script;

namespace DXTreme.Frames
{
    public partial class Manager : Form
    {
        private bool isMenuDropVisible = false;

        public Manager()
        {
            InitializeComponent();
            menudrop();
            changePanel("Home");
        }
        private string staffName;
        private string staffPassword;
        private string staffBranch;

        public string StaffName
        {
            get => staffName;
            set => staffName = value;
        }
        public string StaffPassword
        {
            get => staffPassword;
            set => staffPassword = value;
        }
        public string StaffBranch
        {
            get => staffBranch;
            set => staffBranch = value;
        }

        //Collapse Menu
        private void CollapseMenu()
        {

            if (pnlMenu.Width == 50) // Collapse
            {
                pnlMenu.Width = 223;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;

                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
            else // Expand
            {
                pnlMenu.Width = 50;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Left;

                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = " ";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0);
                }
            }
        }

        //menuDrop
        private void menudrop()
        {
            if (isMenuDropVisible)
            {
                btnMenu.BringToFront();
                btnMenuDown.Hide();
                btnMenu.Show();

            }
            else
            {
                btnMenuDown.BringToFront();
                btnMenu.Hide();
                btnMenuDown.Show();
            }
            CollapseMenu();
            isMenuDropVisible = !isMenuDropVisible;
        }

        //Change Menu
        public void changePanel(string pnl)
        {
            if (pnlShow.Controls.Count > 0)
                pnlShow.Controls.Clear();

            Form formToLoad = null;

            switch (pnl)
            {
                case "Home":
                    lblTitle.Text = "MANAGER DASHBOARD";
                    formToLoad = new HomePage();
                    break;
                case "Members":
                    lblTitle.Text = "LIST OF MEMBERS";
                    ListofMembers lom = new ListofMembers();
                    lom.Username = staffName;
                    lom.Branch = staffBranch;
                    lom.AccType = 1;
                    formToLoad = lom;
                    break;
                case "Equipment":
                    lblTitle.Text = "EQUIPMENT CONDITION";
                    Equipment e = new Equipment();
                    e.AccName = staffName;
                    e.AccType = 1;
                    e.AccBranch = staffBranch;
                    formToLoad = e;
                    break;
                case "Attendance":
                    lblTitle.Text = "ATTENDANCE";
                    formToLoad = new Calendar();
                    break;
                case "Stuff":
                    lblTitle.Text = "LIST OF STAFF";
                    formToLoad = new Staffs();
                    break;
                case "Transaction":
                    lblTitle.Text = "TRANSACTION HISTORY";
                    TransactionHistory th = new TransactionHistory();
                    th.Username = staffName;
                    th.Branch = staffBranch;
                    th.AccType = 1;
                    formToLoad = th;
                    break;
                case "Data":
                    lblTitle.Text = "DATA LOG";
                    DataLog dl = new DataLog();
                    dl.Username = staffName;
                    dl.Branch = staffBranch;
                    formToLoad = dl;
                    break;
            }
            if (formToLoad != null)
            {
                formToLoad.TopLevel = false;
                formToLoad.FormBorderStyle = FormBorderStyle.None;
                formToLoad.Dock = DockStyle.Fill;

                pnlShow.Controls.Add(formToLoad);
                formToLoad.BringToFront();
                formToLoad.Show();
            }
        }

        //Side Panel
        private void side(int option)
        {
            switch (option)
            {
                case 1:
                    sidepanel.Height = btnHome.Height;
                    sidepanel.Top = btnHome.Top;
                    break;
                case 2:
                    sidepanel.Height = btnMembers.Height;
                    sidepanel.Top = btnMembers.Top;
                    break;
                case 3:
                    sidepanel.Height = btnEquip.Height;
                    sidepanel.Top = btnEquip.Top;
                    break;
                case 4:
                    sidepanel.Height = btnAtten.Height;
                    sidepanel.Top = btnAtten.Top;
                    break;
                case 5:
                    sidepanel.Height = btnStuff.Height;
                    sidepanel.Top = btnStuff.Top;
                    break;
                case 6:
                    sidepanel.Height = btnTrans.Height;
                    sidepanel.Top = btnTrans.Top;
                    break;
                case 7:
                    sidepanel.Height = btnDatalog.Height;
                    sidepanel.Top = btnDatalog.Top;
                    break;
            }
        }

        //AdminName
        private string adminName;
        public string _adminName
        {
            get => adminName; set => adminName = value;
        }

        // ==Button==

        //MENU DOWN
        private void btnMenuDown_Click(object sender, EventArgs e)
        {
            menudrop();
        }
        //MENU UP
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menudrop();
        }
        //HOME
        private void btnHome_Click(object sender, EventArgs e)
        {
            changePanel("Home");
            side(1);
        }
        //LIST OF MEMBERS
        private void btnMembers_Click(object sender, EventArgs e)
        {
            changePanel("Members");
            side(2);
        }
        //EQUIPMENT
        private void btnEquip_Click(object sender, EventArgs e)
        {
            changePanel("Equipment");
            side(3);
        }
        //ATTENDANCE
        private void btnAtten_Click(object sender, EventArgs e)
        {
            changePanel("Attendance");
            side(4);
        }
        //STUFF
        private void rjButton2_Click(object sender, EventArgs e)
        {
            changePanel("Staff");
            side(5);
        }
        //TRANSACTION
        private void btnTrans_Click(object sender, EventArgs e)
        {
            changePanel("Transaction");
            side(6);
        }
        //DATA LOG
        private void btnDatalog_Click(object sender, EventArgs e)
        {
            changePanel("Data");
            side(7);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (container.Visible)
            {
                container.Hide();
            }
            else
            {
                container.Show();
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (container.Visible)
            {
                container.Hide();
                accLogOut(this);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (container.Visible)
            {
                container.Hide();

                AccounSettings account = new AccounSettings();
                account.AccName = staffName;
                account.AccType = 1;
                account.Show();
            }
        }
        public void accLogOut(Form acclogout)
        {

            SQLCRUDMethods sql = new SQLCRUDMethods();
            logout log = new logout();
            DialogResult result = log.ShowDialog();

            if (result == DialogResult.Yes)
            {
                returningtosignUp signUp = new returningtosignUp(acclogout);
                sql.updateSelection("Accounts", "Status = 0", "Account_Type = 1", staffName, "Logged Off", staffBranch);
                signUp.Show();
            }
        }
    }
}
