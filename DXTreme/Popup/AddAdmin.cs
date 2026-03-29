using System;
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
    public partial class addadminaccount : Form
    {
        private string staffName = "SuperAdmin";


        public addadminaccount()
        {
            InitializeComponent();
        }

        public string StaffName
        {
            get => staffName;
            set => staffName = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Texts.Equals(txtPasswordConfir.Texts))
            {
                int accType = 0;
                if (cmbType.SelectedItem.ToString().Equals("Manager"))
                {
                    accType = 1;
                }
                SQLCRUDMethods sql = new SQLCRUDMethods();
                sql.addAccount(txtName.Texts, txtPassword.Texts, cmbBranch.SelectedItem.ToString(), StaffName, accType);

                succes s = new succes("Admin Account Creation", "Account successfully created.");
                s.Show();
                this.Dispose();
            }
        }
    }
}
