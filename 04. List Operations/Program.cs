using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArray = comand.Split();
                string operation = comandArray[0];

                if (operation == "Add")
                {
                    int number = int.Parse(comandArray[1]);
                    numbersList.Add(number);
                }
                else if (operation == "Insert")
                {
                    int number = int.Parse(comandArray[1]);
                    int index = int.Parse(comandArray[2]);

                    if (index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersList.Insert(index, number);
                    }
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(comandArray[1]);
                    if (index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersList.RemoveAt(index);
                    }
                }
                else if (operation == "Shift")
                {
                    GetShiftResult(numbersList, comandArray);
                }
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }


        static void  GetShiftResult(List<int> numbersList, string[] comandArray)
        {
            string direction = comandArray[1];

            if (direction == "left")
            {
                int rotation = int.Parse(comandArray[2]);
                int efectiveRotation = rotation % numbersList.Count;

                for (int i = 0; i < efectiveRotation; i++)
                {
                    int firstInd = numbersList[0];
                    numbersList.Remove(firstInd);
                    numbersList.Add(firstInd);

                }
            }
            else if (direction == "right")
            {
                int rotation = int.Parse(comandArray[2]);
                int efectiveRotation = rotation % numbersList.Count;

                for (int i = 0; i < efectiveRotation; i++)
                {
                    int lastInd = numbersList[numbersList.Count - 1];
                    numbersList.Remove(lastInd);
                    numbersList.Insert(0, lastInd);

                }
            }
        } 
    }
}
