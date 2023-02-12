using System;

List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "End")
{
    string[] arrCommands = command.Split().ToArray();
    string operation = arrCommands[0];

    if (operation == "Add")
    {
        int number = int.Parse(arrCommands[1]);
        list.Add(number);
    }
    else if (operation == "Insert")
    {
        int num = int.Parse(arrCommands[1]);
        int index = int.Parse(arrCommands[2]);

        if (index >= 0 && index < list.Count)
        {
            list.Insert(index, num);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (operation == "Remove")
    {
        int index = int.Parse(arrCommands[1]);
        if (index >= 0 && index < list.Count)
        {
            list.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (operation == "Shift")
    {
        string direction = arrCommands[1];
        int count = int.Parse(arrCommands[2]);

        if (direction == "left")
        {
            for (int i = 0; i < count % list.Count; i++)
            {
                int firstNum = list.First();
                list.Add(firstNum);
                list.RemoveAt(0);
            }
        }
        else if (direction == "right")
        {
            for (int i = 0; i < count % list.Count; i++)
            {
                int lastNum = list.Last();
                list.Insert(0, lastNum);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}

Console.WriteLine(string.Join(" ", list));

