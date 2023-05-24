using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLP
{
    public class LeapYear
    {
        int Year;
        public void CheckLeap()
        {
            Console.Write("*****->Find Year is Leap Or not<-*****\n");
            Console.Write("Enter Year-->");
            Year = Convert.ToInt32(Console.ReadLine());
            if(Year % 4==0)
            {
                Console.Write(Year + " is Leap Year\n\n");
            }
            else
            {
                Console.Write(Year + " is Not Leap Year\n\n");
            }

        }
    }
}
