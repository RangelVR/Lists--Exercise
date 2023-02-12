List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacityWagon = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    if (command.Split().First() == "Add")
    {
        int wagonWithPassangers = int.Parse(command.Split().Last());
        train.Add(wagonWithPassangers);
    }
    else
    {
        int passangers = int.Parse(command);

        for (int wagon = 0; wagon < train.Count; wagon++)
        {
            int ocupadedPlaces = train[wagon];

            if (passangers + ocupadedPlaces <= maxCapacityWagon)
            {
                train[wagon] += passangers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", train));
