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
using DXTreme.Components;
using DXTreme.Frames;
using DXTreme.Popup;
using DXTreme.SQL_Script;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DXTreme.Panels
{
    public partial class ListofAdmins : Form
    {
        public ListofAdmins()
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
        public string Branch1
        {
            get => branch;
            set => branch = value;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            addadminaccount admin = new addadminaccount();
            admin.ShowDialog();
            setDataGrid();

        }

        public void setDataGrid()
        {
            admin.RowTemplate.Height = 45;
            admin.Rows.Clear();
            SQLCRUDMethods sQLCRUDMethods = new SQLCRUDMethods();

            ArrayList rows = sQLCRUDMethods.retrieveTableRows("Usernames, Branch, Account_Type, Status", "Accounts", "isArchived = 0 AND Account_Type < 2");

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
                        case 2:
                            accountType = "Super Admin";
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
                    admin.Rows.Add(rows[i], rows[i + 1], accountType, status);
                }
            }
        }

        private void admin_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == admin.Columns["btnEdit"].Index && e.RowIndex >= 0)
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
            if (e.ColumnIndex == admin.Columns["btnDelete"].Index && e.RowIndex >= 0)
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
                string username = admin.Rows[e.RowIndex].Cells["colUsername"].FormattedValue.ToString();
                string accType = admin.Rows[e.RowIndex].Cells["colAccType"].FormattedValue.ToString();
                int type = 0;

                switch (accType)
                {
                    case "Staff":
                        type = 0;
                        break;
                    case "Manager":
                        type = 1;
                        break;
                    case "Super Admin":
                        type = 2;
                        break;
                }

                if (e.ColumnIndex == 4)
                {
                    AccountEdit ae = new AccountEdit();
                    ae.AccName = username;
                    ae.AccType = type;
                    ae.OfficerInCharge = aUsername;
                    ae.OfficerInChargeBranch = branch;
                    ae.ShowDialog();
                }
                else if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this selection?", "Delete " + username, MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SQLCRUDMethods sql = new SQLCRUDMethods();
                        sql.archiveData("Accounts", "Usernames = '" + username + "'", aUsername, username, branch);
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Texts;
            string toSearch = cmbFilter.Texts;
            string order = cmbOrder.Texts;

            startSearch(search, toSearch, order);
        }

        public void startSearch(string search, string toSearch, string order)
        {
            admin.RowTemplate.Height = 45;
            admin.Rows.Clear();
            SQLCRUDMethods sql = new SQLCRUDMethods();

            ArrayList rows = new ArrayList();

            if (toSearch.Equals("SEARCH BY") && order.Equals("ORDER"))
            {
                //Username will be default of search. Default is as is in the database in order of insert.
                rows = sql.retrieveTableRows("Usernames, Branch, Account_Type, Status", "Accounts", "Usernames LIKE '%" + search + "%' AND isArchived = 0 AND Account_Type < 2");
            }




            else if (!toSearch.Equals("SEARCH BY") && order.Equals("ORDER"))
            {
                string condition = "";

                switch (toSearch)
                {
                    case "Staff's Username":
                        condition = "Usernames LIKE '%" + search + "%' AND isArchived = 0 AND Account_Type < 2";
                        break;
                    case "Assigned Branch":
                        break;
                        condition = "Branch LIKE '%" + search + "%' AND isArchived = 0 AND Account_Type < 2";
                    case "Account Type":
                        if ("staff".Contains(search.ToLower()) && "manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type < 2 AND isArchived = 0";
                        }
                        else if ("staff".Contains(search.ToLower()) || !"manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type = 0 AND isArchived = 0";
                        }
                        else if (!"staff".Contains(search.ToLower()) || "manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type = 1 AND isArchived = 0";
                        }
                        break;
                    case "Status":
                        if ("inactive".Contains(search.ToLower()) && "active".Contains(search.ToLower()))
                        {
                            condition = "Status <= 1 AND isArchived = 0 AND Account_Type < 2 ORDER BY Status DESC";
                        }
                        else if ("inactive".Contains(search.ToLower()) || !"active".Contains(search.ToLower()))
                        {
                            condition = "Status = 1 AND isArchived = 0";
                        }
                        break;
                }
                rows = sql.retrieveTableRows("Usernames, Branch, Account_Type, Status", "Accounts", condition);

            }
            else
            {
                string condition = "";

                switch (toSearch)
                {
                    case "Staff's Username":
                        condition = "Usernames LIKE '%" + search + "%' AND isArchived = 0 AND Account_Type < 2 ORDER BY Usernames ";
                        break;
                    case "Assigned Branch":
                        break;
                        condition = "Branch LIKE '%" + search + "%' AND isArchived = 0 AND Account_Type < 2 ORDER BY Branch ";
                    case "Account Type":
                        if ("staff".Contains(search.ToLower()) && "manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type < 2 AND isArchived = 0 ORDER BY Account_Type ";
                        }
                        else if ("staff".Contains(search.ToLower()) || !"manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type = 0 AND isArchived = 0 ORDER BY Account_Type ";
                        }
                        else if (!"staff".Contains(search.ToLower()) || "manager".Contains(search.ToLower()))
                        {
                            condition = "Account_Type = 1 AND isArchived = 0 ORDER BY Account_Type ";
                        }
                        break;
                    case "Status":
                        if ("inactive".Contains(search.ToLower()) && "active".Contains(search.ToLower()))
                        {
                            condition = "Status <= 1 AND isArchived = 0 ORDER BY Status ";
                        }
                        else if ("inactive".Contains(search.ToLower()) || !"active".Contains(search.ToLower()))
                        {
                            condition = "Status = 1 AND isArchived = 0 ORDER BY Status ";
                        }
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
                rows = sql.retrieveTableRows("Usernames, Branch, Account_Type, Status", "Accounts", condition + "" + order);
            }

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
                        case 2:
                            accountType = "Super Admin";
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
                    admin.Rows.Add(rows[i], rows[i + 1], accountType, status);
                }
            }
        }
    }
}
