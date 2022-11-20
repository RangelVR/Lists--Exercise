using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsWhithPassangers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string comand;

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArray = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string typeComand = comandArray[0];
                

                if (typeComand == "Add")
                {
                    int passangers = int.Parse(comandArray[1]);
                    wagonsWhithPassangers.Add(passangers);
                    continue;
                }
                else
                {
                    int passangers = int.Parse(comandArray[0]);

                    for (int i = 0; i < wagonsWhithPassangers.Count; i++)
                    {
                        if (wagonsWhithPassangers[i] + passangers <= maxCapacity)
                        {
                            wagonsWhithPassangers[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonsWhithPassangers));
        }
    }
}
