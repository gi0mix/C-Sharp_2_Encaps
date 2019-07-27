using System;
using System.Collections.Generic;
using System.Text;
using static System.DateTime;
using static System.Console;


namespace StaticClass
{
    static class TimeUtilsClass
    {
        public static void PrintTime()
            => Console.WriteLine(Now.ToShortTimeString());
        public static void PrintDate()
            => Console.WriteLine(Today.ToShortDateString());
    }
}
