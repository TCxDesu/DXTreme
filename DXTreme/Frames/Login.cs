using Microsoft.VisualBasic.Devices;
using DXTreme.SQL_Script;
using System.Collections;
using loading;
using DXTreme.Frames;
using DXTreme.Popup;
using System.Windows.Forms;

namespace DXTreme
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SQLStartup ss = new SQLStartup();
        }

        ArrayList accounts;

        int xMouse, yMouse, xInMouse, yInMouse;
        bool mouseDown = false;

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            xInMouse = MousePosition.X - Bounds.X;
            yInMouse = MousePosition.Y - Bounds.Y;
        }

        private void pnlDrag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                xMouse = MousePosition.X - xInMouse;
                yMouse = MousePosition.Y - yInMouse;

                this.SetDesktopLocation(xMouse, yMouse);
            }
        }

        public void LoginCheck()
        {
            SQLCRUDMethods sQLCRUDMethods = new SQLCRUDMethods();
            accounts = sQLCRUDMethods.retrieveTableRows("Usernames, Passwords, Account_Type, Status, Branch", "Accounts", "isArchived = 0");

            string username = txtUsername.Texts.Trim();
            string password = txtPassword.Texts.Trim();

            bool check = false;



            if (accounts.Count > 0)
            {
                for (int i = 0; i < accounts.Count; i += 5)
                {
                    if (username.Equals(accounts[i].ToString()))
                    {
                        if (password.Equals(accounts[i + 1].ToString()))
                        {
                            if (Convert.ToInt32(accounts[i + 3]) == 1)
                            {
                                failed f = new failed("Login", "This account is already logged in on another device.");
                                f.Show();
                            }
                            else
                            {
                                this.Dispose();
                                new waiting().ShowDialog();
                                switch (Convert.ToInt32(accounts[i + 2]))
                                {
                                    case 0:
                                        Staff staff = new Staff();
                                        staff.StaffName = username;
                                        staff.StaffPassword = password;
                                        staff.StaffBranch = accounts[i + 4] + "";
                                        staff.Show();
                                        break;
                                    case 1:
                                        Manager manager = new Manager();
                                        manager.StaffName = username;
                                        manager.StaffPassword = password;
                                        manager.StaffBranch = accounts[i + 4] + "";
                                        manager.Show();
                                        break;
                                    case 2:
                                        SuperAdmin admin = new SuperAdmin();
                                        admin.Name = username;
                                        admin.AccBranch = accounts[i + 4] + "";
                                        admin.Show();
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username and Password does not match.");
                            check = false;
                            break;
                        }
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            if (check == true)
            {
                lblUser.Visible = true;
                lblWrongUserName.Visible = true;
                lblWrongPassword.Visible = true;
                lblPassword.Visible = true;
                lblUser.BringToFront();
                lblPassword.BringToFront();
                lblWrongUserName.BringToFront();
                lblWrongPassword.BringToFront();
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginCheck();
            }
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && e.Modifiers == Keys.Alt)
            {
                var sQLCRUDMethods = new SQLCRUDMethods();
                var account = sQLCRUDMethods.retrieveTableRows("Usernames, Branch, Status", "Accounts", "isArchived = 0 AND Account_Type = 2");

                if (account.Count == 0)
                {
                    MessageBox.Show("No SuperAdmin account found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (account.Count >= 3 && Convert.ToInt32(account[2]) == 0)
                {
                    this.Hide();
                    new waiting().ShowDialog();

                    var admin = new SuperAdmin
                    {
                        AccName = account[0].ToString(),
                        AccBranch = account[1].ToString()
                    };
                    admin.Show();

                    sQLCRUDMethods.updateSelection("Accounts", "Status = 1", "Account_Type = 2", account[0].ToString(), "Logged In", account[1].ToString());

                    this.Dispose();
                }
                else
                {
                    var f = new failed("Login", "Super Admin is already logged in on another device.");
                    f.Show();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnClose.BringToFront();
            txtPassword.PasswordChar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            btnOpen.BringToFront();
            txtPassword.PasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null; // or panel1 or null if you want no focus
            }));
        }
    }
}
