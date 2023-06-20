using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHarmonic
{
    public class Harmonic
    {
        int HNum;
        double sum=0.0;
        public void CheckNum()
        {
            Console.Write("***-> Find the Nth Harmonic Value <-***\n");
            Console.Write("Enter The Harmonic Number:");
            HNum = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=HNum;i++)
            {

                if (i < HNum)
                {
                    Console.Write("1/"+ i +"+", i);
                    sum += 1 / (float)i;
                   
                }
                if (i == HNum)
                {
                    Console.Write("1/"+ i, i);
                    sum += 1 / (float)i;
                }
             
                //Number = Number + (1 / i);
                // result = Number;

            }
            Console.Write("\nHarmonic Value of "+HNum +" is -->" + sum + "\n\n\n");
        }
    }
}
