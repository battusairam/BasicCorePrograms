using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PowerOfTwo
    {
    public void Power()
    {
        int n;
        Console.WriteLine("Enter a number");
        n = Convert.ToInt32(Console.ReadLine());
        if (0 <= n && n < 31)
        {
            Console.WriteLine("The Power of 2 are:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("");
                Console.WriteLine(Math.Pow(2, i));
            }
        }
        else
        {
            Console.WriteLine("Integer can't take the power of 2 as bigger than 31, Enter Less Than 31");
        }
    }
    }

