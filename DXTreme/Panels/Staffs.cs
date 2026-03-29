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

namespace DXTreme.Panels
{
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
            setDataGrid();
        }
        string search = "";
        private string aUsername;
        private string aBranch;
        private int accType;

        public string Username
        {
            get => aUsername;
            set => aUsername = value;
        }
        public string Branch
        {
            get => aBranch;
            set => aBranch = value;
        }
        public int AccType
        {
            get => accType;
            set => accType = value;
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
        public void setDataGrid()
        {
            listofstaff.RowTemplate.Height = 45;
            listofstaff.Rows.Clear();
            SQLCRUDMethods sQLCRUDMethods = new SQLCRUDMethods();

            ArrayList rows = sQLCRUDMethods.retrieveTableRows("Usernames, Branch, Account_Type, Status", "Accounts", "isArchived = 0 AND Account_Type < 1 AND Branch = '"+ aBranch +"'");

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i += 4)
                {
                    string accountType = "";
                    switch (Convert.ToInt32(rows[i + 2]))
                    {
                        case 0:
                            accountType = "Staff";
                            break;
                        case 1:
                            accountType = "Manager";
                            break;
                    }
                    string status = "";
                    switch (Convert.ToInt32(rows[i + 3]))
                    {
                        case 0:
                            status = "OFFLINE";
                            break;
                        case 1:
                            status = "ONLINE";
                            break;
                    }
                    listofstaff.Rows.Add(rows[i], rows[i + 1], accountType, status);
                }
            }
        }

        private void admin_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == listofstaff.Columns["btnEdit"].Index && e.RowIndex >= 0)
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
            if (e.ColumnIndex == listofstaff.Columns["btnDelete"].Index && e.RowIndex >= 0)
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

        private void admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string username = listofstaff.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

                if (e.ColumnIndex == 4)
                {
                    AccountEdit ae = new AccountEdit();
                    ae.AccName = username;
                    ae.AccType = 0;
                    ae.OfficerInCharge = aUsername;
                    ae.OfficerInChargeBranch = aBranch;
                    ae.ShowDialog();
                }
                else if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this selection?", "Delete " + username, MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SQLCRUDMethods sql = new SQLCRUDMethods();
                        sql.archiveData("Accounts", "Usernames = '" + username + "'", aUsername, username, aBranch);
                    }
                }
                setDataGrid();
            }
            catch (Exception)
            {
            }
        }
    }
}
