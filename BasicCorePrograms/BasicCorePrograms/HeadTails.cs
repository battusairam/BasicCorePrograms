using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_Tails
{
    public class HeadsTails
    {
        int NumOFCount, TailCount = 0, HeadCount = 0, PerOfHead, PerOfTails;
        public void CheckHeadTail()
        {
            Console.Write("*****----Flip Coin and print percentage of Heads and Tails----*****\n");
            Console.Write("Enter No. of times you want to Flip the Coin:" + "\n");
            NumOFCount = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= NumOFCount; j++)
            {
                Random random_num = new Random();
                int randomheadtail = random_num.Next(0, 1);
                if (randomheadtail < 0.5)
                {
                    TailCount++;
                }
                else
                {
                    HeadCount++;
                }

                Console.Write("****---> Percentage of Head vs Tails<---****\n");
                PerOfHead = HeadCount / NumOFCount * 100;
                PerOfTails = TailCount / NumOFCount * 100;
                Console.Write("Percentage of Head-->" + PerOfHead + "%\n");
                Console.Write("Percentage of Tails-->" + PerOfTails + "%\n\n");

            }
        }
    }
}
