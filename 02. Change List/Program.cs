using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string comand;

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArray = comand.Split();
                string operation = comandArray[0];

                switch (operation)
                {
                    case "Delete":
                        int deletedElement = int.Parse(comandArray[1]);
                        numbers.Remove(deletedElement);
                        break;

                    case "Insert":
                        int elemet = int.Parse(comandArray[1]);
                        int position = int.Parse(comandArray[2]);
                        numbers.Insert(position, elemet);
                        break;
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
