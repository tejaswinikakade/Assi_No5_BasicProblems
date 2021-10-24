using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class LeapYear
    {
        public static void GetLeapYr()
        {
            int year;

            Console.WriteLine("Check whether a given year is leap year or not:");


            Console.Write("Input a year (4 digits only) : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
   
