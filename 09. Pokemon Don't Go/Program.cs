using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (distances.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                
                if (index > distances.Count - 1)
                {
                    int lastNum = distances[distances.Count - 1];
                    sum += lastNum;
                    for (int i = 0; i < distances.Count; i++)
                    {
                        distances[i] = distances[i] + lastNum;
                    }
                }
                else if (index < 0)
                {
                    int firstNum = distances[0];
                    sum += firstNum;
                    for (int i = 0; i < distances.Count; i++)
                    {
                        distances[i] = distances[i] + firstNum;
                    }
                }
                else
                {
                    int removedNum = distances[index];
                    sum += removedNum;
                    distances.RemoveAt(index);

                    for (int i = 0; i < distances.Count; i++)
                    {
                        int num = distances[i];
                        if (num > removedNum)
                        {
                            distances[i] = num - Math.Abs(removedNum);
                        }
                        else
                        {
                            distances[i] = num + removedNum;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
