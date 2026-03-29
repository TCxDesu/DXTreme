using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXTreme.Frames
{
    public partial class Calendar : Form
    {
        public static int _year, _month;

        public Calendar()
        {
            InitializeComponent();
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblDateAndYear.Text = monthName.ToUpper() + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int totalDays = DateTime.DaysInMonth(year, month);
            int startDayOfWeek = (int)startOfTheMonth.DayOfWeek;

            for (int i = 0; i < startDayOfWeek; i++)
            {
                days emptyDay = new days("");
                flowLayoutPanel1.Controls.Add(emptyDay);
            }

            //Add actual days
            for (int day = 1; day <= totalDays; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);
                days dayControl = new days(day.ToString());          

                flowLayoutPanel1.Controls.Add(dayControl);
            }

            int totalCells = startDayOfWeek + totalDays;
            int remainingCells = 7 - (totalCells % 7);
            if (remainingCells < 7)
            {
                for (int i = 0; i < remainingCells; i++)
                {
                    days emptyDay = new days("");
                    flowLayoutPanel1.Controls.Add(emptyDay);
                }
            }
        }


        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        //CLICK
        private void rjButton1_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }
    }
}
