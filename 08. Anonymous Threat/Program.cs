using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()!.Split(' ').ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "3:1")
            {
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                if (command[0] == "merge")
                {
                    if (startIndex < 0) startIndex = 0;
                    if (endIndex >= input.Count) endIndex = input.Count - 1;
                    for (int diff = endIndex - startIndex; diff > 0; --diff)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }
                if (command[0] == "divide")
                {
                    int subParts = int.Parse(command[2]);
                    int partSize = input[startIndex].Length / endIndex;
                    int counter = subParts;
                    int off = 1;
                    while (counter > 1)
                    {
                        counter--;
                        input.Insert(startIndex + off, new string(input[startIndex].Take(partSize).ToArray()));
                        off++;
                        input[startIndex] = new string(input[startIndex].Skip(partSize).ToArray());
                    }
                    input.Insert(startIndex + off, input[startIndex]);
                    input.RemoveAt(startIndex);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
