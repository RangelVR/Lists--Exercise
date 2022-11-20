using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    nums.RemoveAll(x => x == command[1]);
                }
                else if (command[0] == "Insert")
                {
                    nums.Insert(int.Parse(command[2]), command[1] );
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
