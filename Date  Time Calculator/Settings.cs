using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date__Time_Calculator
{
    internal class Settings
    {
        public static DateTime pickfrom = DateTime.Now;
        public static DateTime pickto = DateTime.Now;
        public static int years = 0, months = 0, weeks = 0, days = 0, hours = 0, minutes = 0, seconds = 0, milliseconds = 0, total = 0, input = 0, output = 0;
        public static bool monday, tuesday, wednesday, thursday, friday, saturday, sunday;
    }
}
