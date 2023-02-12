List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] commArr = command.Split();

    switch (commArr[0])
    {
        case "Delete":
            int numToDelete = int.Parse(commArr[1]);
            list.RemoveAll(x => x == numToDelete);
            break;

        case "Insert":
            int numToInsert = int.Parse(commArr[1]);
            int position = int.Parse(commArr[2]);
            list.Insert(position, numToInsert);
            break;
    }
}

Console.WriteLine(string.Join(" ", list));
