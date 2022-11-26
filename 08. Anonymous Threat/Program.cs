using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            

            while (command[0] != "3:1")
            {
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                if (command[0] == "merge")
                {
                    if (startIndex < 0) startIndex = 0;
                    if (endIndex >= input.Count) endIndex = input.Count - 1;

                    for (int i = endIndex - startIndex; i > 0; i--)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int partSize = input[startIndex].Length / int.Parse(command[2]);
                    int counter = endIndex;
                    int off = 1;

                    while (counter > 0)
                    {
                        counter--;
                        input.Insert(startIndex + off, new string(input[startIndex].Take(partSize).ToArray()));
                        off++;
                        input[startIndex] = new string(input[startIndex].Skip(partSize).ToArray());
                    }
                    input.RemoveAt(startIndex);
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
