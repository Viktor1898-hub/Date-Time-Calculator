using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TimeSpan timeSpan = Settings.pickto - Settings.pickfrom;
            Settings.hours = timeSpan.Hours;
            Settings.minutes = timeSpan.Minutes;
            Settings.seconds = timeSpan.Seconds;
            Settings.milliseconds = timeSpan.Milliseconds;
            Settings.total = timeSpan.Days;
            Settings.years = Settings.pickto.Year - Settings.pickfrom.Year;
            Settings.months = Settings.pickto.Month - Settings.pickfrom.Month;
            Settings.days = Settings.pickto.Day - Settings.pickfrom.Day;
            if (Settings.days < 0)
            {
                Settings.months--;
                Settings.days += DateTime.DaysInMonth(Settings.pickfrom.Year, Settings.pickfrom.Month - 1);
            }
            if (Settings.months < 0)
            {
                Settings.years--;
                Settings.months += 12;
            }
            Settings.weeks = Settings.days / 7;
            Settings.days = Settings.days % 7;
        }
        public static void WorkCounter()
        {
            DateTime from = Settings.pickfrom;
            DateTime to = Settings.pickto;
            int count = 0;
            int dow = 0;
            int idx = 0;
            bool[] days = new bool[] {Settings.monday, Settings.tuesday, Settings.wednesday, Settings.thursday, Settings.friday, Settings.saturday, Settings.sunday};
            for (DateTime start = from; start <= to; start = start.AddDays(1))
            {
                dow = (int)start.DayOfWeek;
                idx = (dow + 6) % 7;
                if (days[idx])
                {
                    count++;
                }
            }
            Settings.days = count;
        }
    }
}
