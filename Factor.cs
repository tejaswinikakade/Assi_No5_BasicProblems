using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class Factor
    {

        public static void GetFactors()
        {
            int num;
            int x;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factors of the entered number are :");

            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }


        }
    }
}
