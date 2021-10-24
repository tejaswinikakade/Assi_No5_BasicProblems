using System;
using System.Collections.Generic;
using System.Text;

namespace day5_Assigment
{
    class FlipCoin
    {
        public const int numCoinFlip = 50;
        public static void flipCoinPersentage()
        {
            Console.WriteLine("How many time the coin should be fliped?");
            int coinFlip = Convert.ToInt32(Console.ReadLine());

            int heads = 0;
            int tails = 0;


            for (int i = 0; i < coinFlip; i++)
            {
                Random random = new Random();
                int status = (int)(random.Next(0, 2) + 0.5);

                if (status == 0)
                {
                    heads++;
                }
                else
                    tails++;
            }
            Console.WriteLine("Head : " + heads + " Times");
            Console.WriteLine("Tail : " + tails + " Times");
            Console.WriteLine("Head Won " + (heads * 100) / coinFlip + "% Times");
            Console.WriteLine("Tail Won " + (tails * 100) / coinFlip + "% Times");

        }
    }
}

