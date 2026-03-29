using System;
using System.CodeDom;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DXTreme.Popup
{
    public partial class AccountEdit : Form
    {
        private string accName;
        private int accType;
        private string accPass;
        private string accBranch;
        ArrayList info = new ArrayList();

        private string oic;
        private string oicBranch;

        public AccountEdit()
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
        public string OfficerInCharge
        {
            get => oic;
            set => oic = value;
        }
        public string OfficerInChargeBranch
        {
            get => oicBranch;
            set => oicBranch = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string aName = txtUsername.Texts.Trim();
            string aPass = txtPassword.Texts.Trim();
            string aBranch = txtBranch.Texts;
            string aType = txtAccType.Texts;

            if (cmbBranch.Visible == true)
            {
                aBranch = cmbBranch.Texts;
            }
            if (cmbType.Visible == true)
            {
                aType = cmbType.Texts;
            }

            int type = 0;
            switch (aType)
            {
                case "Staff Account":
                    type = 0;
                    break;
                case "Manager Account":
                    type = 1;
                    break;
        }
            string activity;
            if (aName.Length > 0 && aPass.Length > 0 && aBranch.Length > 0 && aBranch.Length > 0)
            {
                if (!accName.Equals(aName))
                {
                    activity = $@"Updated {aName} Data (Formerly {accName})";
                }
                else {
                    activity = $@"Updated {aName} Data)";
                }
                if (!accName.Equals(aName) || !accPass.Equals(aPass) || !txtBranch.Texts.Equals(aBranch) || !txtAccType.Texts.Equals(aType))
                {
                    DialogResult result = MessageBox.Show("Do you want to save these changes?", "Update " + accName, MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SQLCRUDMethods sql = new SQLCRUDMethods();
                            string changes = @$"Usernames = '{aName}', Passwords = '{aPass}', Branch = '{aBranch}', Account_Type = {type}";

                            sql.updateSelection("Accounts", changes, "Usernames = '" + accName + "'", oic, activity, oicBranch);

                            succes s = new succes("Account Update", "Update successfull.");
                            s.ShowDialog();
                            this.Dispose();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
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

            cmbBranch.Texts = accBranch;
            cmbType.Texts = txtAccType.Texts;
            cmbBranch.Visible = false;
            cmbType.Visible = false;
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            txtUsername.isReadOnly = false;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            txtPassword.isReadOnly = false;
        }

        private void btnChangeBranch_Click(object sender, EventArgs e)
        {
            txtBranch.Visible = false;
            cmbBranch.Visible = true;
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            txtAccType.Visible = false;
            cmbType.Visible = true;
        }
    }
}
