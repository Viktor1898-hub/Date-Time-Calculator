using System;
using System.Collections.Generic;
using System.Configuration;
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
        public static void LeapCount()
        {
            DateTime from = Settings.pickfrom;
            DateTime to = Settings.pickto;
            Settings.total = 0;
            int year = 0;
            if (Settings.pickfrom.Year != Settings.pickto.Year)
            {
                for (DateTime start = from; start <= to; start = start.AddYears(1))
                {
                    year = start.Year;
                    if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
                    {
                        Settings.total++;
                    }
                }
            }
        }
        public static void Converter()
        {
            if (Settings.input == Settings.output)
            {
                Settings.total = 0;
            }
            if (Settings.input == 0)
            {
                if (Settings.output == 0)
                {
                    Settings.total = 12;
                }
                if (Settings.output == 1)
                {
                    Settings.total = 365;
                }
                if (Settings.output == 2)
                {
                    Settings.total = 8760;
                }
                if (Settings.output == 3)
                {
                    Settings.total = 525600;
                }
                if (Settings.output == 4)
                {
                    Settings.total = 31536000;
                }
            }
            if (Settings.input == 1)
            {
                if (Settings.output == 1)
                {
                    Settings.total = 30;
                }
                if (Settings.output == 2)
                {
                    Settings.total = 720;
                }
                if (Settings.output == 3)
                {
                    Settings.total = 43200;
                }
                if (Settings.output == 4) 
                {
                    Settings.total = 2592000;
                }
            }
            if (Settings.input == 2)
            {
                if (Settings.output == 2)
                {
                    Settings.total = 24;
                }
                if (Settings.output == 3)
                {
                    Settings.total = 1440;
                }
                if (Settings.output == 4)
                {
                    Settings.total = 86400;
                }
            }
            if (Settings.input == 3)
            {
                if (Settings.output == 3)
                {
                    Settings.total = 60;
                }
                if (Settings.output == 4)
                {
                    Settings.total = 3600;
                }
            }
            if (Settings.input == 4) 
            {
                if (Settings.output == 4)
                {
                    Settings.total = 60;
                }
            }
        }
        public static void LiveFor()
        {
            Settings.seconds = DateTime.Now.Second - Settings.pickfrom.Second;
            Settings.minutes = DateTime.Now.Minute - Settings.pickfrom.Minute;
            Settings.hours = DateTime.Now.Hour - Settings.pickfrom.Hour;
            Settings.years = DateTime.Now.Year - Settings.pickfrom.Year;
            Settings.months = DateTime.Now.Month - Settings.pickfrom.Month;
            Settings.days = DateTime.Now.Day - Settings.pickfrom.Day;

            if (Settings.seconds < 0)
            {
                Settings.minutes--;
                Settings.seconds += 60;
            }
            if (Settings.minutes < 0)
            {
                Settings.hours--;
                Settings.minutes += 60;
            }
            if (Settings.hours < 0)
            {
                Settings.days--;
                Settings.hours += 24;
            }
            if (Settings.days < 0)
            {
                Settings.months--;
                var prevMonth = DateTime.Now.AddMonths(-1);
                Settings.days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
            }
            if (Settings.months < 0)
            {
                Settings.years--;
                Settings.months += 12;
            }
        }
        public static void NextBirthday()
        {
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, Settings.pickfrom.Month, Settings.pickfrom.Day, Settings.pickfrom.Hour, Settings.pickfrom.Minute, Settings.pickfrom.Second);
            if (nextBirthday <= DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            TimeSpan timeSpan = nextBirthday - DateTime.Now;
            DateTime temp = DateTime.Now;
            int months = 0;
            while (temp.AddMonths(1) <= nextBirthday)
            {
                temp = temp.AddMonths(1);
                months++;
            }
            Settings.months = months;
            Settings.days = (nextBirthday - temp).Days;
            Settings.hours = timeSpan.Hours;
            Settings.minutes = timeSpan.Minutes;
            Settings.seconds = timeSpan.Seconds;
        }
    }
}
