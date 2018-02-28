
using System;

namespace Libs.Easy
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);
            string time = dt.ToString("HH:mm:ss");

            return time;
        }
    }
}
