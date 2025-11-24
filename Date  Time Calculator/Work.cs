using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date__Time_Calculator
{
    internal class Work
    {
        public static void DateCompar()
        {
            Settings.years = 0;
            Settings.months = 0;
            Settings.weeks = 0;
            Settings.days = 0;
            Settings.hours = 0;
            Settings.minutes = 0;
            Settings.seconds = 0;
            Settings.milliseconds = 0;
            TimeSpan timeSpan = Settings.dcto - Settings.dcfrom;
            Settings.hours = timeSpan.Hours;
            Settings.minutes = timeSpan.Minutes;
            Settings.seconds = timeSpan.Seconds;
            Settings.milliseconds = timeSpan.Milliseconds;
            Settings.total = timeSpan.Days;
            Settings.years = Settings.dcto.Year - Settings.dcfrom.Year;
            Settings.months = Settings.dcto.Month - Settings.dcfrom.Month;
            Settings.days = Settings.dcto.Day - Settings.dcfrom.Day;
            if (Settings.days < 0)
            {
                Settings.months--;
                Settings.days += DateTime.DaysInMonth(Settings.dcfrom.Year, Settings.dcfrom.Month - 1);
            }
            if (Settings.months < 0)
            {
                Settings.years--;
                Settings.months += 12;
            }
            Settings.weeks = Settings.days / 7;
            Settings.days = Settings.days % 7;
        }
    }
}
