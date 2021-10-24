using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class Harmonic
    {
        public static void GetHarmonicNum()
        {
            int Hn;
            float harmonic = 1;

            Console.WriteLine("Enter a nth of harmonic number");
            Hn = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Hn; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine(harmonic);
        }
    }
}
 
