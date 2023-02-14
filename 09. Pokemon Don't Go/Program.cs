List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

int sum = 0;

while (list.Count > 0)
{
    int indexToRemove = int.Parse(Console.ReadLine());

	int firstElemet = list[0];
	int lastElement = list[list.Count - 1];
    int removedElement = 0;

    if (indexToRemove < 0)
	{
        if (indexToRemove < 0)
        {
            indexToRemove = 0;
        }

        removedElement = firstElemet;
        sum += removedElement;
        list.RemoveAt(0);
		list.Insert(0, lastElement);
        GetIncreaseOrDecreaseElements(list, indexToRemove, removedElement);


    }
    else if (indexToRemove >= list.Count)
	{
        if (indexToRemove > list.Count - 1)
        {
            indexToRemove = list.Count - 1;
        }

        removedElement = lastElement;
        sum += lastElement;
        list.RemoveAt(list.Count - 1);
		list.Add(firstElemet);
        GetIncreaseOrDecreaseElements(list, indexToRemove, removedElement);
    }
    else
	{
        removedElement = list[indexToRemove];
		sum += removedElement;
		list.RemoveAt(indexToRemove);
		GetIncreaseOrDecreaseElements(list, indexToRemove, removedElement);
    }
}

Console.WriteLine(sum);



static List<int> GetIncreaseOrDecreaseElements(List<int> list, int indexToRemove, int removedElement)
{

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] <= removedElement)
        {
            list[i] += removedElement;
        }
        else
        {
            list[i] -= removedElement;
        }
    }

    return list;
}
