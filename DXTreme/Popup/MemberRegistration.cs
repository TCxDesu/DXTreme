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
    public partial class MemberRegistration : Form
    {
        private string staffName = "SuperAdmin";
        private string staffBranch = "";
        public MemberRegistration()
        {
            InitializeComponent();
        }
        public string StaffName
        {
            get => staffName;
            set => staffName = value;
        }
        public string StaffBranch
        {
            get => staffBranch;
            set => staffBranch = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string fullName = txtLN.Texts.Trim() + ", " + txtFN.Texts.Trim() + " " + txtMI.Texts.Trim();
            string option = cmbOptions.Texts;
            string type = cmbType.Texts;
            string price = lblNumber.Text;

            try
            {
                if (fullName.Trim().Length > 0 && !option.Equals("Choose an Option") && !type.Equals("Type of Membership"))
                {
                    SQLCRUDMethods sql = new SQLCRUDMethods();
                    sql.addMember(fullName, type, option, staffBranch, Convert.ToDouble(price), staffName);
                    succes s = new succes("Member Registration", "Member successfully registered");
                    s.ShowDialog();
                    this.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cmbOptions.Texts;
            string price = "0.00";
            switch (option)
            {
                case "Yearly Membership":
                    price = "500.00";
                    break;
                case "Monthly Membership":
                    price = "1300.00";
                    break;
            }
            lblNumber.Text = price;
        }

        private void cmbType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbType.Texts;

            if (type.Equals("Student"))
            {
                cmbOptions.Enabled = false;
                cmbOptions.Texts = "------------------";
                string price = "1000.00";
                lblNumber.Text = price;
            }
            else
            {
                cmbOptions.Enabled = true;
                cmbOptions.SelectedIndex = 0;
            }
        }

        private void cmbOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
