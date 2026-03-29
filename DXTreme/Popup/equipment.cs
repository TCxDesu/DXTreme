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
    public partial class equipment : Form
    {
        public equipment()
        {
            InitializeComponent();
        }

        private string accName;
        private string accBranch;
        private int accType;
        public bool ShowButtonAdd
        {
            get => btnAdd.Visible;
            set => btnAdd.Visible = value;
        }

        public bool ShowBranchComboBox
        {
            get => cmbBranch.Visible;
            set => cmbBranch.Visible = value;
        }
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
        public string BranchText
        {
            get
            {
                return accBranch;
            }
            set
            {
                accBranch = value;
                txtBranch.Text = accBranch;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEquipmentToList add = new AddEquipmentToList();
            add.AccBranch = accBranch;
            add.AccName = accName;
            add.AccType = accType;
            add.ShowDialog();
            setFields();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void equipment_Load(object sender, EventArgs e)
        {
            switch (accType)
            {
                case 1:
                    cmbBranch.Visible = false;
                    txtBranch.Visible = true;
                    break;
                case 2:
                    cmbBranch.Visible = true;
                    txtBranch.Visible = false;
                    break;
                default:
                    cmbBranch.Visible = false;
                    txtBranch.Visible = true;
                    break;
            }
            setFields();
        }

        public void setFields()
        {
            txtDate.Texts = DateTime.Now.ToString("MMMM dd, yyyy");
            txtTime.Texts = DateTime.Now.ToString("hh:mm tt");

            cmbEquip.Items.Clear();
            ArrayList equipment = new ArrayList();

            SQLCRUDMethods sql = new SQLCRUDMethods();
            equipment = sql.retrieveTableRows("eql.*", "EquipmentList eql", "LEFT JOIN",
                "EquipmentMaintenance eqm ON eqm.EquipmentName = eql.EquipmentName " +
                "AND eqm.Branch = eql.Branch",
                "eqm.EquipmentName IS NULL");

            if (equipment.Count > 0)
            {
                for (int i = 0; i < equipment.Count; i += 2)
                {
                    cmbEquip.Items.Add(equipment[i]);
                }
            }
        }

        private void equipment_Shown(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null;
            }));
        }
    }
}
