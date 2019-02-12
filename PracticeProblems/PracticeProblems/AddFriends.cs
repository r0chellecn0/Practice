using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class AddFriends
    {
        public static void friendLikes(string names)
        {
            var friendNames = new List<string>();

            while (true)
            {
                Console.WriteLine("enter friend's name");
                var friendName = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(friendName))
                    break;
                friendNames.Add(friendName);

            }
            int countNames = friendNames.Count;
            Console.WriteLine(countNames);
        }
    }
}
