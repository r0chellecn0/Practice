using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SpeedCamera
    {
        public static void SpeedCam()
        {
            Console.WriteLine("please enter the speed limit");
            int limit = Int16.Parse(Console.ReadLine());
            Console.WriteLine("please enter the car speed");
            int speed = Int16.Parse(Console.ReadLine());

            if (limit > speed)
            {
                Console.WriteLine("ok");
            }
            else if (limit < speed)
            {
                int milesOver = speed - limit;
                int demeritPoint = milesOver / 5;
                if (milesOver <= 60)
                {
                    Console.WriteLine($"you went {milesOver} miles over.  demerit points = {demeritPoint}");
                }
                else Console.WriteLine($"you went {milesOver} miles over.You have {demeritPoint} demerit points. Your license is suspended");
            }
            else
            {
                Console.WriteLine("you're cutting int close");
            }
        }
    }
}