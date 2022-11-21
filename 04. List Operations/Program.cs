using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (index >= 0 && index < nums.Count)
                        {
                            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        int remIndex = int.Parse(command[1]);
                        if (remIndex >= 0 && remIndex < nums.Count)
                        {
                            nums.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        int repTimes = int.Parse(command[2]) % nums.Count;
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < repTimes; i++)
                            {
                                int firstNum = nums.First();
                                nums.RemoveAt(0);
                                nums.Add(firstNum);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < repTimes; i++)
                            {
                                int lastNum = nums[nums.Count - 1];
                                nums.Remove(lastNum);
                                nums.Insert(0, lastNum);
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        
    }
}
