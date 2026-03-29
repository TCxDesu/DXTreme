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
using DXTreme.Popup;
using DXTreme.SQL_Script;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DXTreme.Panels
{
    public partial class ListofMembers : Form
    {
        public ListofMembers()
        {
            InitializeComponent();
            setDataGrid();
        }
        string search = "";
        private string aUsername;
        private string branch;
        private int accType;

        public string Username
        {
            get => aUsername;
            set => aUsername = value;
        }
        public string Branch
        {
            get => branch;
            set => branch = value;
        }
        public int AccType
        {
            get => accType;
            set => accType = value;
        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MemberRegistration mr = new MemberRegistration();
            mr.ShowDialog();
            setDataGrid();
        }

        public void setDataGrid()
        {
            listofmember.RowTemplate.Height = 45;
            listofmember.Rows.Clear();
            SQLCRUDMethods sQLCRUDMethods = new SQLCRUDMethods();

            ArrayList rows = sQLCRUDMethods.retrieveTableRows("Member_Name, Membership_Type, Membership_Option, Date_of_Membership, Date_of_Expiration", "Members", "isArchived = 0");

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i += 5)
                {
                    listofmember.Rows.Add(rows[i], rows[i + 1], rows[i + 2], rows[i + 3], rows[i + 4]);
                }
            }
        }

        private void listofmember_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == listofmember.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                using (SolidBrush backBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image img = Properties.Resources.pen;
                int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
                int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

                e.Graphics.DrawImage(img, new Rectangle(imgX, imgY, img.Width, img.Height));
                e.Handled = true;
            }
            if (e.ColumnIndex == listofmember.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                using (SolidBrush backBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image img = Properties.Resources.trash;
                int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
                int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

                e.Graphics.DrawImage(img, new Rectangle(imgX, imgY, img.Width, img.Height));
                e.Handled = true;
            }
        }

        private void listofmember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string memberName = listofmember.Rows[e.RowIndex].Cells["colName"].FormattedValue.ToString();

                if (e.ColumnIndex == 5)
                {

                }
                else if (e.ColumnIndex == 6)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this selection?", "Delete " + memberName, MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SQLCRUDMethods sql = new SQLCRUDMethods();
                        sql.archiveData("Members", "Member_Name = '" + memberName + "'", aUsername, memberName, branch);
                    }
                }
                setDataGrid();
            }
            catch (Exception)
            {
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() =>
                {
                    txtSearch__TextChanged(sender, e);
                }));
            }
            catch (Exception)
            {
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Texts;
            string toSearch = cmbFilter.Texts;
            string order = cmbOrder.Texts;

            startSearch(search, toSearch, order);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        public void startSearch(string search, string toSearch, string order)
        {
            listofmember.RowTemplate.Height = 45;
            listofmember.Rows.Clear();
            SQLCRUDMethods sql = new SQLCRUDMethods();

            ArrayList rows = new ArrayList();

            if (toSearch.Equals("SEARCH BY") && order.Equals("ORDER"))
            {
                //Member_Name will be default of search. Default is as is in the database in order of insert.
                rows = sql.retrieveTableRows("Member_Name, Membership_Type, Membership_Option, Date_of_Membership, Date_of_Expiration", "Members", "Member_Name LIKE '%" + search + "%' AND isArchived = 0");
            }
            else if (!toSearch.Equals("SEARCH BY") && order.Equals("ORDER"))
            {
                string condition = "";

                switch (toSearch)
                {
                    case "Name":
                        condition = "Membership_Name LIKE '%" + search + "%' AND isArchived = 0";
                        break;
                    case "Membership Type":
                        break;
                        condition = "Membership_Type LIKE '%" + search + "%' AND isArchived = 0";
                    case "Membership Option":
                        condition = "Membership_Option LIKE '%" + search + "%' AND isArchived = 0";
                        break;
                    case "Date of Membership":
                        condition = "Date_of_Membership LIKE '%" + search + "%' AND isArchived = 0";
                        break;
                    case "Date of Expiration":
                        condition = "Date_of_Expiration LIKE '%" + search + "%' AND isArchived = 0";
                        break;
                }
                rows = sql.retrieveTableRows("Member_Name, Membership_Type, Membership_Option, Date_of_Membership, Date_of_Expiration", "Members", condition);

            }
            else
            {
                string condition = "";

                switch (toSearch)
                {
                    case "Name":
                        condition = "Membership_Name LIKE '%" + search + "%' AND isArchived = 0 ORDER BY Name ";
                        break;
                    case "Membership Type":
                        break;
                        condition = "Membership_Type LIKE '%" + search + "%' AND isArchived = 0 ORDER BY Membership_Type ";
                    case "Membership Option":
                        condition = "Membership_Option LIKE '%" + search + "%' AND isArchived = 0 ORDER BY Membership_Option ";
                        break;
                    case "Date of Membership":
                        condition = "Date_of_Membership LIKE '%" + search + "%' AND isArchived = 0 ORDER BY Date_of_Membership ";
                        break;
                    case "Date of Expiration":
                        condition = "Date_of_Expiration LIKE '%" + search + "%' AND isArchived = 0 ORDER BY Date_of_Membership ";
                        break;
                }

                if (order.Equals("Highest to Lowest"))
                {
                    order = "DESC";
                }
                else
                {
                    order = "ASC";
                }
                rows = sql.retrieveTableRows("Member_Name, Membership_Type, Membership_Option, Date_of_Membership, Date_of_Expiration", "Members", condition + "" + order);
            }

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i += 5)
                {
                    listofmember.Rows.Add(rows[i], rows[i + 1], rows[i + 2], rows[i + 3], rows[i + 4]);
                }
            }
        }
    }
}
