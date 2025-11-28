using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date__Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComparerFromPicker.Value = DateTime.Now;
            ComparerToPicker.Value = DateTime.Now;
            DWKSelectFromPicker.Value = DateTime.Now;
            DWKSelectToPicker.Value = DateTime.Now;
            this.Controls.Add(InfoPanel);
            this.Controls.Add(DateCompPanel);
            this.Controls.Add(DateWorkCountPanel);
            this.Controls.Add(LeapPanel);
            this.LeapPanel.BringToFront();
        }
        private void UnixTimer_Tick(object sender, EventArgs e)
        {
            long unixTimeSeconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            TimerLabel.Text = unixTimeSeconds.ToString();
        }


        private void DCGoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComparerFromPicker.Value > ComparerToPicker.Value)
                {
                    MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Date Time Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Work.DateCompar();
                Settings.pickfrom = ComparerFromPicker.Value;
                Settings.pickto = ComparerToPicker.Value;
                DCYersNumLbl.Text = Settings.years.ToString();
                DCMonthNumLbl.Text = Settings.months.ToString();
                DCWeekNumLbl.Text = Settings.weeks.ToString();
                DCDayNumLbl.Text = Settings.days.ToString();
                DCHourNum.Text = Settings.hours.ToString() + ':';
                DCMinutNum.Text = Settings.minutes.ToString() + ':';
                DCSecondNum.Text = Settings.seconds.ToString() + ':';
                DCMSNum.Text = Settings.milliseconds.ToString();
                DCTotalNumLbl.Text = Settings.total.ToString();
                if (Settings.hours < 10) DCHourNum.Text = "0" + DCHourNum.Text;
                if (Settings.minutes < 10) DCMinutNum.Text = "0" + DCMinutNum.Text;
                if (Settings.seconds < 10) DCSecondNum.Text = "0" + DCSecondNum.Text;
                if (Settings.milliseconds < 10) DCMSNum.Text = "00" + DCMSNum.Text;
                else if (Settings.milliseconds < 100) DCMSNum.Text = "0" + DCMSNum.Text;
            }
            catch { }
        }

        private void DCDateTimeNowBtn_Click(object sender, EventArgs e)
        {
            ComparerFromPicker.Value = DateTime.Now;
            ComparerToPicker.Value = DateTime.Now;
        }

        private void DWCDTNBtn_Click(object sender, EventArgs e)
        {
            DWKSelectFromPicker.Value = DateTime.Now;
            DWKSelectToPicker.Value = DateTime.Now;
            DWCResultLbl.Text = "0 Working days";
        }

        private void DWCGoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DWKSelectFromPicker.Value > DWKSelectToPicker.Value)
                {
                    MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Date Time Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Settings.pickfrom = DWKSelectFromPicker.Value;
                Settings.pickto = DWKSelectToPicker.Value;
                Settings.monday = DWCMondayCheckBox.Checked;
                Settings.tuesday = DWCTuesdayCheckBox.Checked;
                Settings.wednesday = DWCWednesdayCheckBox.Checked;
                Settings.thursday = DWCThursdayCheckBox.Checked;
                Settings.friday = DWCFridayCheckBox.Checked;
                Settings.saturday = DWCSaturdayCheckBox.Checked;
                Settings.sunday = DWCSundayCheckBox.Checked;
                Work.WorkCounter();
                DWCResultLbl.Text = Settings.days.ToString() + " Working days";
            }
            catch { }
        }

        private void LeapDTNBtn_Click(object sender, EventArgs e)
        {
            LeapFromPicker.Value = DateTime.Now;
            LeapToPicker.Value = DateTime.Now;
            LeapResLbl.Text = "0 Leap years";
        }

        private void LeapGoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LeapFromPicker.Value > LeapToPicker.Value)
                {
                    MessageBox.Show("The 'From' date cannot be later than the 'To' date.", "Date Time Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Settings.pickfrom = LeapFromPicker.Value;
                Settings.pickto = LeapToPicker.Value;
                Work.LeapCount();
                if (Settings.total == 1)
                {
                    LeapResLbl.Text = Settings.total.ToString() + " Leap year";
                }
                else
                {
                    LeapResLbl.Text = Settings.total.ToString() + " Leap years";
                }
            }
            catch { }
        }
    }
}
