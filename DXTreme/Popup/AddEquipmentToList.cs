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
    public partial class AddEquipmentToList : Form
    {
        public AddEquipmentToList()
        {
            InitializeComponent();
        }

        private string accName;
        private int accType;
        private string accBranch;
        //public bool ShowBranchComboBox
        //{
        //    get => cmbBranch.Visible;
        //    set
        //    {
        //        cmbBranch.Visible = value;
        //        txtBranch.Visible = !value;
        //    }
        //}
        public string AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }

        public string AccBranch
        {
            get => accBranch;
            set => accBranch = value;
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
            string equipment = txtName.Texts.ToString().Trim();
                   

            SQLCRUDMethods sql = new SQLCRUDMethods();
            bool result = sql.addEquipmentToList(equipment, AccBranch, AccName);

            if (result) {
                this.Dispose();
            }
        }

        private void AddEquipmentToList_Load(object sender, EventArgs e)
        {
            //switch (accType)
            //{
            //    case 1:
            //        cmbBranch.Visible = false;
            //        txtBranch.Visible = true;
            //        txtBranch.Texts = accBranch;
            //        break;
            //    case 2:
            //        cmbBranch.Visible = true;
            //        txtBranch.Visible = false;
            //        break;
            //}
        }
    }
}

