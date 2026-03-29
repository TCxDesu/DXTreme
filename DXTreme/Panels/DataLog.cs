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

namespace DXTreme.Panels
{
    public partial class DataLog : Form
    {
        public DataLog()
        {
            InitializeComponent();
            setDataGrid();
        }
        string search = "";
        private string aUsername;
        private string branch;

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
            tblLog.RowTemplate.Height = 45;
            tblLog.Rows.Clear();
            SQLCRUDMethods sQLCRUDMethods = new SQLCRUDMethods();

            ArrayList rows = sQLCRUDMethods.retrieveTableRows("Data_Log_ID, Staff_in_Charge, Activity, Date_and_Time", "Transaction_History", "isArchived = 0");

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i += 4)
                {
                    tblLog.Rows.Add(rows[i], rows[i + 1], rows[i + 2], rows[i + 3]);
                }
            }
        }

        private void tblLog_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tblLog.Columns["btnDel"].Index && e.RowIndex >= 0)
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

        private void tblLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataID = tblLog.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();

            if (e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this selection?", "Delete Transaction", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SQLCRUDMethods sql = new SQLCRUDMethods();
                    sql.archiveData("Data_Log", "Data_Log_ID = '" + dataID + "'", aUsername, dataID, branch);
                }
            }
            setDataGrid();
        }
    }
}
