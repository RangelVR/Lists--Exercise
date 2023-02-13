List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

string[] command = Console.ReadLine().Split().ToArray();

while (command[0] != "3:1")
{

    if (command[0] == "merge")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);


        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (endIndex >= input.Count)
        {
            endIndex = input.Count - 1;
        }

        for (int i = startIndex; i < endIndex; i++)
        {
            input[startIndex] += input[startIndex + 1];
            input.RemoveAt(startIndex + 1);
        }
    }
    else if (command[0] == "divide")
    {
        int index = int.Parse(command[1]);
        int partitions = int.Parse(command[2]);
        string dividedString = input[index];
        int subPartitions = dividedString.Length / partitions;
        int counter = 1;

        for (int i = 1; i < partitions; i++)
        {
            string part = new string (dividedString.Take(subPartitions).ToArray());

            input.Insert(index + counter, part);
            counter++;

            dividedString = new string(dividedString.Skip(subPartitions).ToArray());

        }
        input.Insert(index + counter, dividedString);
        input.RemoveAt(index);
    }

    command = Console.ReadLine().Split().ToArray();
}

Console.WriteLine(string.Join(" ", input));
