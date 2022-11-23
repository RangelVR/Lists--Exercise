using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExc
{
    class MainClass
    {
        public static void Main()
        {


            List<string> nums = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            List<string> numbers = new List<string>();

            foreach (var str in nums)
            {
                numbers.AddRange(str.Split( " ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

    }

}