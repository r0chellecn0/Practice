using System;

namespace PracticeProblems
{
    class Max
    {
        public static void MaxNum(int input)
        {
            Console.WriteLine("please enter an integer");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter another integer");
            int num2 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"max num is {num1}");
            }
            else if (num2 < num1)
            {
                Console.WriteLine($"max num is {num2}");
            }
            else Console.WriteLine($"first number {num1} is equal to second number {num2}");
        }
    }
}
