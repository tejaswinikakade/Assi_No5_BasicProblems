using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class OddEven
    {
        public static void getOddEven()
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }
        }
    }
}
 