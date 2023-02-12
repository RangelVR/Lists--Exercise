List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();


while (true)
{
    if (cards1.Count == 0 || cards2.Count == 0)
    {
        break;
    }

    int firstCardDeck1 = cards1.First();
    int firstCardDeck2 = cards2.First();

    if (cards1[0] > cards2[0])
    {
        cards1.Add(firstCardDeck2);
        cards1.Add(firstCardDeck1);
        cards2.RemoveAt(0);
        cards1.RemoveAt(0);
    }
    else if (cards2[0] > cards1[0])
    {
        cards2.Add(firstCardDeck1);
        cards2.Add(firstCardDeck2);
        cards2.RemoveAt(0);
        cards1.RemoveAt(0);
    }
    else
    {
        cards2.RemoveAt(0);
        cards1.RemoveAt(0);
    }
}

if (cards1.Sum() > cards2.Sum())
{
    Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
}
