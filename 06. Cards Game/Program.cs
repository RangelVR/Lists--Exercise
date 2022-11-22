using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayerCards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            GetTheWinnerOfPlayers(firstPlayerCards, secondPlayerCards);
            PrintTheWinner(firstPlayerCards, secondPlayerCards);
            
        }

        static void GetTheWinnerOfPlayers(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            while (true)
            {
                int firstIndexOfFirstPlayer = firstPlayerCards[0];
                int firstIndexOfSecondPlayer = secondPlayerCards[0];

                if (firstIndexOfFirstPlayer > firstIndexOfSecondPlayer)
                {
                    secondPlayerCards.Remove(firstIndexOfSecondPlayer);
                    firstPlayerCards.Add(firstIndexOfSecondPlayer);
                    firstPlayerCards.Remove(firstIndexOfFirstPlayer);
                    firstPlayerCards.Add(firstIndexOfFirstPlayer);
                }
                else if (firstIndexOfFirstPlayer < firstIndexOfSecondPlayer)
                {
                    firstPlayerCards.Remove(firstIndexOfFirstPlayer);
                    secondPlayerCards.Add(firstIndexOfFirstPlayer);
                    secondPlayerCards.Remove(firstIndexOfSecondPlayer);
                    secondPlayerCards.Add(firstIndexOfSecondPlayer);
                }
                else
                {
                    firstPlayerCards.Remove(firstIndexOfFirstPlayer);
                    secondPlayerCards.Remove(firstIndexOfSecondPlayer);

                }
                if (firstPlayerCards.Count == 0 || secondPlayerCards.Count == 0)
                {
                    break;
                }

            }
        }

        static void PrintTheWinner(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            if (firstPlayerCards.Count != 0)
            {
                firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else if (secondPlayerCards.Count != 0)
            {
                secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
        }
    }
}
