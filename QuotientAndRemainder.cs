using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class QuotientAndRemainder
    {
        public static void QuesRem()
        {
            int dividend;
            int divisor;

            Console.WriteLine("Enter the dividend");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;


            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
