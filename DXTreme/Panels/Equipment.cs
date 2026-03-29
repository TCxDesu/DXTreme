using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.Popup;

namespace DXTreme.Panels
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private int accType;
        private string accBranch;
        private string accName;

        public int AccType
        {
            get => accType;
            set => accType = value;
        }
        public string AccBranch
        {
            get => accBranch;
            set => accBranch = value;
        }
        public string AccName
        {
            get => accName;
            set => accName = value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pnlSearch.Width == 71)
            {
                pnlSearch.Width = 450;
                pnlSearch.BorderRadius = 55;
            }
            else
            {
                pnlSearch.Width = 71;
                pnlSearch.BorderRadius = 55;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (accType == 0)
            {
                equipment equ = new equipment();
                equ.BranchText = accBranch;
                equ.Name = accName;
                equ.ShowButtonAdd = false;
                equ.ShowDialog();
            }
            else
            {
                equipment equ = new equipment();
                equ.AccName = accName;
                equ.AccType = accType;
                equ.BranchText = accBranch;
                equ.ShowDialog();
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
    }
}
