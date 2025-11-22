using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date__Time_Calculator
{
    internal class Work
    {
        public static DateTime DateTimeNow;
        private static void UnixTime()
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            long unixTimeSeconds = dateTimeOffset.ToUnixTimeSeconds();
            DateTimeNow = DateTimeOffset.FromUnixTimeSeconds(unixTimeSeconds).DateTime;
        }
    }
}
