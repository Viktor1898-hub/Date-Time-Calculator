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
            BirthPicker.Value = DateTime.Now;
            this.Controls.Add(InfoPanel);
            this.Controls.Add(DateCompPanel);
            this.Controls.Add(DateWorkCountPanel);
            this.Controls.Add(LeapPanel);
            this.Controls.Add(ConverterPanel);
            this.Controls.Add(BirthdayPanel);
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
                    ComparerFromPicker.Value = DateTime.Now;
                    ComparerToPicker.Value = DateTime.Now;
                    DCYersNumLbl.Text = "0";
                    DCMonthNumLbl.Text = "0";
                    DCWeekNumLbl.Text = "0";
                    DCDayNumLbl.Text = "0";
                    DCHourNum.Text = "00: ";
                    DCMinutNum.Text = "00: ";
                    DCSecondNum.Text = "00: ";
                    DCMSNum.Text = "000";
                    DCTotalNumLbl.Text = "0";
                }
                Settings.pickfrom = ComparerFromPicker.Value;
                Settings.pickto = ComparerToPicker.Value;
                Work.DateCompar();
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

        private void ConvertGoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.input = ConvertInputBox.SelectedIndex;
                Settings.output = ConvertOutputBox.SelectedIndex;
                Work.Converter();
                var result = Settings.total * (double)ConvertUpDown.Value;
                result = Math.Floor(result);
                ConvertResLbl.Text = ConvertUpDown.Value.ToString();
                if (ConvertInputBox.SelectedIndex == 0)
                {
                    ConvertResLbl.Text += " Year";
                }
                if (ConvertInputBox.SelectedIndex == 1)
                {
                    ConvertResLbl.Text += " Month";
                }
                if (ConvertInputBox.SelectedIndex == 2)
                {
                    ConvertResLbl.Text += " Day";
                }
                if (ConvertInputBox.SelectedIndex == 3)
                {
                    ConvertResLbl.Text += " Hour";
                }
                if (ConvertInputBox.SelectedIndex == 4)
                {
                    ConvertResLbl.Text += " Minute";
                }
                if (ConvertInputBox.SelectedIndex == 5)
                {
                    ConvertResLbl.Text += " Second";
                }
                if (ConvertUpDown.Value > 1)
                {
                    ConvertResLbl.Text += "s";
                }
                ConvertResLbl.Text += " equals " + result.ToString();
                if (ConvertOutputBox.SelectedIndex == 0)
                {
                    ConvertResLbl.Text += " year";
                }
                if (ConvertOutputBox.SelectedIndex == 1)
                {
                    ConvertResLbl.Text += " month";
                }
                if (ConvertOutputBox.SelectedIndex == 2)
                {
                    ConvertResLbl.Text += " day";
                }
                if (ConvertOutputBox.SelectedIndex == 3)
                {
                    ConvertResLbl.Text += " hour";
                }
                if (ConvertOutputBox.SelectedIndex == 4)
                {
                    ConvertResLbl.Text += " minute";
                }
                if (ConvertOutputBox.SelectedIndex == 5)
                {
                    ConvertResLbl.Text += " second";
                }
                if (result > 1)
                {
                    ConvertResLbl.Text += "s";
                }
            }
            catch { }
        }

        private void LiveForTimer_Tick(object sender, EventArgs e)
        {
            Work.LiveFor();
            LiveForResLbl.Text = $"{Settings.years}Y {Settings.months}M {Settings.days}D {Settings.hours}H {Settings.minutes}Min {Settings.seconds}Sec";
        }

        private void BirthGoBtn_Click(object sender, EventArgs e)
        {
            if (BirthPicker.Value > DateTime.Now)
            {
                BirthPicker.Value = DateTime.Now;
                MessageBox.Show("The date cannot be later than today", "Date Time Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DateTime.Now.Year - BirthPicker.Value.Year <= 18)
            {
                Age18Lbl.Text = "You will be 18 years old";
            }
            else
            {
                Age18Lbl.Text = "You were 18 years old";
            }
            if (DateTime.Now.Year - BirthPicker.Value.Year >= AgeNumeric.Value)
            {
                AgeNumeric.Value = DateTime.Now.Year - BirthPicker.Value.Year + 1;
                MessageBox.Show("Expected age cannot be lower than your age", "Date Time Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            WillBeLbl.Text = $"You will be {AgeNumeric.Value} years old";
            Settings.input = (int)AgeNumeric.Value;
            Settings.pickfrom = BirthPicker.Value;
            LiveForTimer.Start();
            NextBirthdayTimer.Start();
            Age18Timer.Start();
            ExpectAgeTimer.Start();
        }

        private void NextBirthdayTimer_Tick(object sender, EventArgs e)
        { 
            Work.NextBirthday();
            NextBResLbl.Text = $"{Settings.months}M {Settings.days}D {Settings.hours}H {Settings.minutes}Min {Settings.seconds}Sec";
        }

        private void Age18Timer_Tick(object sender, EventArgs e)
        {
            Work.Age18();
            Age18ResLbl.Text = $"{Settings.years}Y {Settings.months}M {Settings.days}D {Settings.hours}H {Settings.minutes}Min {Settings.seconds}Sec";
        }

        private void ExpectAgeTimer_Tick(object sender, EventArgs e)
        {
            Work.ExpectAge();
            WillBeResLbl.Text = $"{Settings.years}Y {Settings.months}M {Settings.days}D {Settings.hours}H {Settings.minutes}Min {Settings.seconds}Sec";
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            ConverterPanel.Visible = false;
            DateWorkCountPanel.Visible = false;
            LeapPanel.Visible = false;
            DateCompPanel.Visible = false;
            InfoPanel.Visible = true;
            InfoPanel.BringToFront();
        }

        private void DateComparerBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            ConverterPanel.Visible = false;
            DateWorkCountPanel.Visible = false;
            LeapPanel.Visible = false;
            InfoPanel.Visible = false;
            DateCompPanel.Visible = true;
            DateCompPanel.BringToFront();
        }

        private void DateWorkCountBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            ConverterPanel.Visible = false;
            DateWorkCountPanel.Visible = true;
            LeapPanel.Visible = false;
            DateCompPanel.Visible = false;
            InfoPanel.Visible = false;
            DateWorkCountPanel.BringToFront();
        }

        private void LeapCounterBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            ConverterPanel.Visible = false;
            DateWorkCountPanel.Visible = false;
            LeapPanel.Visible = true;
            DateCompPanel.Visible = false;
            InfoPanel.Visible = false;
            LeapPanel.BringToFront();
        }

        private void TimeConverterBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            ConverterPanel.Visible = true;
            DateWorkCountPanel.Visible = false;
            LeapPanel.Visible = false;
            DateCompPanel.Visible = false;
            InfoPanel.Visible = false;
            ConverterPanel.BringToFront();
        }

        private void BirthdayInformerBtn_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = true;
            ConverterPanel.Visible = false;
            DateWorkCountPanel.Visible = false;
            LeapPanel.Visible = false;
            DateCompPanel.Visible = false;
            InfoPanel.Visible = false;
            BirthdayPanel.BringToFront();
        }
    }
}
