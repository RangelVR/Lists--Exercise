using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int commands = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < commands; i++)
            {
                string[] comm = Console.ReadLine().Split().ToArray();
                string name = comm[0];

                if (comm.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if (comm.Length == 4)
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));

        }
    }
}
