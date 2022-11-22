using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombInfo[0];
            int bombPower = bombInfo[1];

            while (nums.Contains(bomb))
            {
                int indexOfBomb = nums.IndexOf(bomb);
                GetSumOfNums(nums, indexOfBomb, bombPower);
            }
            Console.WriteLine(nums.Sum());
        }

        
        static void GetSumOfNums(List<int> nums, int indexOfBomb, int bombPower)
        {
            int rightCount = indexOfBomb + bombPower;
            for (int i = indexOfBomb; i <= rightCount; i++)
            {
                if (indexOfBomb >= nums.Count)
                {
                    break;
                }
                nums.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - bombPower;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int i = leftCount; i < indexOfBomb; i++)
            {
                nums.RemoveAt(leftCount);
            }
        }
    }
}
