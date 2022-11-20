using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<string> listOfGuests = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split();
                string name = inputArray[0];

                if (inputArray.Length == 3)
                {
                    if (listOfGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    listOfGuests.Add(name);
                }
                else if (inputArray.Length == 4)
                {
                    if (listOfGuests.Contains(name))
                    {
                        listOfGuests.Remove(name);
                    }
                    else if (!listOfGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfGuests));
        }
    }
}
