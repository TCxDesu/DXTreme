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

namespace DXTreme.Panels
{
    public partial class ActiveMembers : Form
    {
        public ActiveMembers()
        {
            InitializeComponent();
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

        private void ActiveMembers_Load(object sender, EventArgs e)
        {
            SQLCRUDMethods sql = new SQLCRUDMethods();
            sql.retrieveTableRows("Members");
        }
    }
}
