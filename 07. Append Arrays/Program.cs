using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1Cards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2Cards = Console.ReadLine().Split().Select(int.Parse).ToList();

            GetWinner(player1Cards, player2Cards);
            PrintWinner(player1Cards, player2Cards);
        }

        static void GetWinner(List<int> cards1, List<int> cards2)
        {
            while (true)
            {
                int firstCardDeck1 = cards1[0];
                int firstCardDeck2 = cards2[0];

                if (firstCardDeck1 == firstCardDeck2)
                {
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                }
                else if (firstCardDeck1 > firstCardDeck2)
                {
                    cards1.Add(firstCardDeck2);
                    cards1.Add(firstCardDeck1);
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                }
                else if (firstCardDeck2 > firstCardDeck1)
                {
                    cards2.Add(firstCardDeck1);
                    cards2.Add(firstCardDeck2);
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                }

                if (cards1.Count == 0 || cards2.Count == 0)
                {
                    break;
                }
            }
        }

        static void PrintWinner(List<int> player1Cards, List<int> player2Cards)
        {
            if (player1Cards.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {player2Cards.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {player1Cards.Sum()}");
            }
        }
    }
}
