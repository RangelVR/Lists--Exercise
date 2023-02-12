List<int> bombField = Console.ReadLine().Split().Select(int.Parse).ToList();
int[] specialNumWithPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

int specialNum = specialNumWithPower[0];
int bombPower = specialNumWithPower[1];

while (bombField.Contains(specialNum))
{
    int indexOfSpecialNum = bombField.IndexOf(specialNum);

    int leftCount = indexOfSpecialNum - bombPower;
    int rightCount = indexOfSpecialNum + bombPower;

    if (leftCount < 0)
    {
        leftCount = 0;
    }

    if (rightCount >= bombField.Count)
    {
        rightCount = bombField.Count - 1;
    }

    for (int i = leftCount; i <= rightCount; i++)
    {
        bombField.RemoveAt(leftCount);
    }
}

Console.WriteLine(bombField.Sum());
