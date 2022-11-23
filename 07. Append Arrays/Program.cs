using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").Reverse().ToList();
            List<string> resultArray = new List<string>();

            foreach (var arr in input)
            {
                resultArray.AddRange(arr.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
