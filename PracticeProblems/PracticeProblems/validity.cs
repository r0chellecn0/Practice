using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class validity
    {
        public static void Validity(int input)
        {
            Console.WriteLine("Please enter an integer between 1 and 10");
            int num = Int16.Parse(Console.ReadLine());
            if (num <=10 && num >= 1)
            {
                Console.WriteLine("valid");
            }
            else Console.WriteLine("invalid");
        }
    }
}
