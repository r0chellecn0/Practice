using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Divisible
    {
        public static void DivByThree()
        {
            int count = 0;
            int i;
            for (i=0;i<100;i++)
            {
                while (i%3==0)
                {
                    count++;
                    break;
                }                          
            }
            Console.WriteLine($"{count} numbers are divisble by 3");
        }
    }
}
