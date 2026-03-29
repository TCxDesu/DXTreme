using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXTreme.Popup;

namespace DXTreme.Frames
{
    public partial class days : UserControl
    {
        string _days, date, weekday;
        public days(String day)
        {
            InitializeComponent();
            _days = day;
            lblNumber.Text = day;
            checkBox1.Hide();

            if (!string.IsNullOrEmpty(_days))
            {
                try
                {
                    int dayInt = int.Parse(_days);
                    DateTime dayDate = new DateTime(Calendar._year, Calendar._month, dayInt);

                    setPanel(dayInt, dayDate);

                    //Check today
                    if (dayDate.Date == DateTime.Today)
                    {
                        lblNumber.ForeColor = Color.Blue;
                    }
                    else if (dayDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        lblNumber.ForeColor = Color.FromArgb(204, 0, 0); //Sunday
                    }
                    else
                    {
                        lblNumber.ForeColor = Color.FromArgb(0, 0, 0); //normal days
                    }
                }
                catch (Exception)
                {
                    lblNumber.ForeColor = Color.FromArgb(64, 64, 64); //invalid days
                }
            }
            else
            {
                lblNumber.Text = "";
                this.Enabled = false;
            }
        }

        public void setPanel(int dayInt, DateTime dayDate)
        {
            int toDate = Convert.ToInt32(DateTime.Today.Day);
            int toYear = Convert.ToInt32(DateTime.Today.Year);
            int toMonth = Convert.ToInt32(DateTime.Today.Month);

            if (dayDate.Month == toMonth)
            {
                if (dayDate.Year == toYear)
                {
                    if (dayDate.Day != toDate)
                    {
                        if (dayDate.Day > toDate)
                        {
                            this.BackColor = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            this.BackColor = Color.FromArgb(128, 128, 128);
                        }
                    }
                    else {
                        this.BackColor = Color.FromArgb(80, 200, 120);
                    }
                }
                else if (dayDate.Year > toYear)
                {
                    this.BackColor = Color.FromArgb(255, 255, 255);
                }
                else {
                    this.BackColor = Color.FromArgb(128, 128, 128);
                }
            }
            else if (dayDate.Month > toMonth && dayDate.Year >= toYear)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (dayDate.Month < toMonth && dayDate.Year > toYear)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (dayDate.Month < toMonth && dayDate.Year <= toYear)
            {
                this.BackColor = Color.FromArgb(128, 128, 128);
            }
            else if (dayDate.Month > toMonth && dayDate.Year < toYear)
            {
                this.BackColor = Color.FromArgb(128, 128, 128);
            }
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void days_Load(object sender, EventArgs e)
        {

        }

        //CLICK IN CALENDAR
        private void pnlClick_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(80, 200, 120))
            {
                if (checkBox1.Checked == false)
                {
                    checkBox1.Checked = true;
                    attendace atten = new attendace();
                    atten.ShowDialog();
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            else if (this.BackColor == Color.FromArgb(128, 128, 128))
            {

            }
            else
            {

            }
        }
    }
}
