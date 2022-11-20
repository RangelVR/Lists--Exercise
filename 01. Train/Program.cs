using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        int passangers = int.Parse(command[0]);
                        if (passangers + nums[i] <= maxCapacity)
                        {
                            nums[i] += passangers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
