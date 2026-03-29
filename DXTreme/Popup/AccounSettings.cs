using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.SQL_Script;

namespace DXTreme.Popup
{
    public partial class AccounSettings : Form
    {
        private string accName;
        private int accType;
        private string accPass;
        private string accBranch;
        ArrayList info = new ArrayList();

        public AccounSettings()
        {
            InitializeComponent();
        }

        SQLCRUDMethods sql = new SQLCRUDMethods();

        public string AccName
        {
            get => accName;
            set => accName = value;
        }
        public int AccType
        {
            get => accType;
            set => accType = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void AccounSettings_Load(object sender, EventArgs e)
        {
            info = sql.retrieveTableRows("Usernames, Passwords, Branch, Account_Type", "Accounts", "Usernames = '" + AccName + "' AND Account_Type = '" + AccType + "'");

            txtUsername.Texts = info[0].ToString();
            txtPassword.Texts = info[1].ToString();
            txtBranch.Texts = info[2].ToString();

            switch (accType)
            {
                case 0:
                    txtAccType.Texts = "Staff Account";
                    break;
                case 1:
                    txtAccType.Texts = "Manager Account";
                    break;
                case 2:
                    txtAccType.Texts = "Super Admin Account";
                    break;
            }

            accPass = txtPassword.Texts;
            accBranch = txtBranch.Texts;
        }
    }
}
