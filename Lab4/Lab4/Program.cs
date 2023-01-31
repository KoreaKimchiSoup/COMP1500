using System.Diagnostics;
using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calendar.IsLeapYear(1600));
            Console.WriteLine(Calendar.IsLeapYear(2000));
            Console.WriteLine(Calendar.IsLeapYear(2400));
            Console.WriteLine(Calendar.IsLeapYear(1988));
            Console.WriteLine(Calendar.IsLeapYear(1996));
            Console.WriteLine(Calendar.IsLeapYear(2020));

            Console.WriteLine(Calendar.IsLeapYear(2017));
            Console.WriteLine(Calendar.IsLeapYear(2018));
            Console.WriteLine(Calendar.IsLeapYear(2019));
            Console.WriteLine(Calendar.IsLeapYear(1700));
            Console.WriteLine(Calendar.IsLeapYear(2100));
            Console.WriteLine(Calendar.IsLeapYear(2200));
            /*
            Debug.Assert(Calendar.IsLeapYear(1600));
            Debug.Assert(Calendar.IsLeapYear(2000));
            Debug.Assert(Calendar.IsLeapYear(2400));
            Debug.Assert(Calendar.IsLeapYear(1988));
            Debug.Assert(Calendar.IsLeapYear(1996));
            Debug.Assert(Calendar.IsLeapYear(2020));

            Debug.Assert(!Calendar.IsLeapYear(2017));
            Debug.Assert(!Calendar.IsLeapYear(2018));
            Debug.Assert(!Calendar.IsLeapYear(2019));
            Debug.Assert(!Calendar.IsLeapYear(1700));
            Debug.Assert(!Calendar.IsLeapYear(2100));
            Debug.Assert(!Calendar.IsLeapYear(2200));
            
            Debug.Assert(Calendar.GetDaysInMonth(1600, 12) == 31);
            Debug.Assert(Calendar.GetDaysInMonth(1996, 2) == 29);
            Debug.Assert(Calendar.GetDaysInMonth(1999, 4) == 30);
            Debug.Assert(Calendar.GetDaysInMonth(2019, 2) == 28);
            Debug.Assert(Calendar.GetDaysInMonth(1996, 8) == 31);
            Debug.Assert(Calendar.GetDaysInMonth(1999, 9) == 30);
            */
        }
    }
}