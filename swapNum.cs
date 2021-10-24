using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class swapNum
    {
        public static void swap()
        {
            int a;
            int b;

            Console.WriteLine("Enter value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.WriteLine("After swap a= " + a + " b= " + b);
           
        }
    }
}
  /* /or we can use temp variable for this problem but i dont how to use temp in c#/*/