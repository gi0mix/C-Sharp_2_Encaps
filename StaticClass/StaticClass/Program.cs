using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Static Utility Class *****");
            TimeUtilsClass.PrintDate();
            TimeUtilsClass.PrintTime();
        }
    }
}
