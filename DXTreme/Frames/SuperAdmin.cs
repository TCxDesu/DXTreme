using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.Panels;
using DXTreme.Popup;
using DXTreme.Properties;
using DXTreme.SQL_Script;

namespace DXTreme.Frames
{
    public partial class SuperAdmin : Form
    {
        private bool menuExpand = false;
        private string adminName;
        private bool isDropdownVisible = false;
        private bool isMenuDropVisible = false;
        private Image home = Resources.House;
        private succes sucForm;

        private string accName;
        private string accBranch;

        public SuperAdmin()
        {
            InitializeComponent();
            menudrop();
            changePanel("Home");

        }
        //Drop list
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

            if (menuExpand)
            {
                //Expand
                pnlDrop.Height += 10;
                if (pnlDrop.Height >= pnlDrop.MaximumSize.Height)
                {
                    pnlDrop.Height = pnlDrop.MaximumSize.Height;
                    menuTransition.Stop();
                }
            }
            else
            {
                //Collapse
                pnlDrop.Height -= 10;
                if (pnlDrop.Height <= pnlDrop.MinimumSize.Height)
                {
                    pnlDrop.Height = pnlDrop.MinimumSize.Height;
                    menuTransition.Stop();
                }
            }
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
                    lblTitle.Text = "SUPER ADMIN DASHBOARD";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    formToLoad = new HomePage();
                    break;
                case "ActiveMembers":
                    lblTitle.Text = "ACTIVE MEMBERS";
                    formToLoad = new ActiveMembers();
                    break;
                case "Members":
                    lblTitle.Text = "LIST OF MEMBERS";
                    ListofMembers lom = new ListofMembers();
                    lom.Username = accName;
                    lom.Branch = accBranch;
                    formToLoad = lom;
                    break;
                case "Admins":
                    lblTitle.Text = "LIST OF STAFFS";
                    ListofAdmins loa = new ListofAdmins();
                    loa.Username = accName;
                    loa.Branch1 = accBranch;
                    formToLoad = loa;
                    break;
                case "Equipment":
                    lblTitle.Text = "EQUIPMENT CONDITION";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    Equipment e = new Equipment();
                    e.AccName = accName;
                    e.AccType = 2;
                    e.AccBranch = accBranch;
                    formToLoad = e;
                    break;
                case "Transaction":
                    lblTitle.Text = "TRANSACTION HISTORY";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    TransactionHistory th = new TransactionHistory();
                    th.Username = accName;
                    th.Branch = accBranch;
                    th.AccType = 2;
                    formToLoad = th;
                    break;
                case "Attendance":
                    lblTitle.Text = "ATTENDANCE";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    formToLoad = new Calendar();
                    break;
                case "Data":
                    lblTitle.Text = "DATA LOG";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    DataLog dl = new DataLog();
                    dl.Username = accName;
                    dl.Branch = accBranch;
                    formToLoad = dl;
                    break;
                case "Archive":
                    lblTitle.Text = "ARCHIVE";
                    if (menuExpand)
                    {
                        ToggleDropdown();
                        menuTransition.Stop();
                        menuExpand = false;
                        menuTransition.Start();
                    }
                    Archive a = new Archive();
                    a.Username = accName;
                    a.Branch = accBranch;
                    a.AccType = 2;
                    formToLoad = a;
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

        //AdminName
        public string _adminName
        {
            get => adminName; set => adminName = value;
        }
        public string AccName
        {
            get => accName;
            set => accName = value;
        }
        public string AccBranch
        {
            get => accBranch;
            set => accBranch = value;
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
                    menuButton.Text = "   " + menuButton.Tag.ToString();
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
                    menuButton.Text = "  ";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0);
                }
            }
        }

        //DropDown
        private void ToggleDropdown()
        {
            if (isDropdownVisible)
            {
                btnListUp.BringToFront();
            }
            else
            {
                btnListDown.BringToFront();
            }

            menuTransition.Start();

            menuExpand = !menuExpand;
            isDropdownVisible = !isDropdownVisible;
        }

        //MenuDrop
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

        //Logout
        public void accLogOut(Form acclogout)
        {
            SQLCRUDMethods sql = new SQLCRUDMethods();
            logout log = new logout();
            DialogResult result = log.ShowDialog();

            if (result == DialogResult.Yes)
            {
                returningtosignUp signUp = new returningtosignUp(acclogout);
                sql.updateSelection("Accounts", "Status = 0", "Account_Type = 2", "SuperAdmin", "Logged Off", "DXtreme Fitness Gym - Mabolo Branch");
                signUp.Show();
            }
        }

        //======Button=====

        //Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menudrop();
        }

        private void btnMenuDown_Click(object sender, EventArgs e)
        {
            menudrop();
        }

        //Home
        private void btnHome_Click(object sender, EventArgs e)
        {

            changePanel("Home");
        }

        //ListUp
        private void btnList_Click(object sender, EventArgs e)
        {

            ToggleDropdown();
        }
        //ListDown
        private void btnListDown_Click(object sender, EventArgs e)
        {
            ToggleDropdown();

        }

        //Active Member
        private void btnActiveM_Click(object sender, EventArgs e)
        {
            changePanel("ActiveMembers");
        }

        //Admin
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            changePanel("Admins");
        }

        //Members
        private void btnMembers_Click(object sender, EventArgs e)
        {
            changePanel("Members");
        }

        //Equipment
        private void btnEquip_Click(object sender, EventArgs e)
        {
            changePanel("Equipment");

        }

        //Transaction
        private void btnTrans_Click(object sender, EventArgs e)
        {
            changePanel("Transaction");


        }
        //Attendance
        private void btnAtten_Click(object sender, EventArgs e)
        {
            changePanel("Attendance");


        }

        //Data Log
        private void btnDatalog_Click(object sender, EventArgs e)
        {

            changePanel("Data");
        }

        //Archive
        private void rjButton1_Click(object sender, EventArgs e)
        {
            changePanel("Archive");

        }

        //Account click
        private void btnAccount_Click(object sender, EventArgs e)
        {
            //cmbAccount.DroppedDown = true;
            if (container.Visible)
            {
                container.Hide();
            }
            else
            {
                container.Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (container.Visible)
            {
                container.Hide();

                AccounSettings account = new AccounSettings();
                account.AccName = accName;
                account.AccType = 2;
                account.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (container.Visible)
            {
                container.Hide();
                accLogOut(this);
            }
        }
    }
}
