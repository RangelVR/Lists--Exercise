int n = int.Parse(Console.ReadLine());
List<string> guestList = new List<string>();

while (n > 0)
{
    string command = Console.ReadLine();
    string name = command.Split().First();

    if (command.Contains("not"))
    {
        if (guestList.Contains(name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
    else
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            n--;
            continue;
        }

        guestList.Add(name);
    }

    n--;
}

Console.WriteLine(string.Join(Environment.NewLine, guestList));
