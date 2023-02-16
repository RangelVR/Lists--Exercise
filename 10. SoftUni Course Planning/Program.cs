using System;

List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

string command = Console.ReadLine();

while (command != "course start")
{
    string[] arrComm = command.Split(":").ToArray();
    string lesson = arrComm[1];

    switch (arrComm[0])
    {
        case "Add":
            if (!list.Contains(arrComm[1]))
            {
                list.Add(arrComm[1]);
            }
            break;

        case "Insert":
            int index = int.Parse(arrComm[2]);

            if (index >= 0 && index <= list.Count)
            {
                if (!list.Contains(lesson))
                {
                    list.Insert(index, lesson);
                }
            }
            break;

        case "Remove":
            if (list.Contains(lesson))
            {
                list.Remove(lesson);
                list.Remove(lesson + "-Exercise");
            }
            break;

        case "Exercise":
            if (!list.Contains(lesson + "-Exercise"))
            {
                if (list.Contains(lesson))
                {
                    list.Insert(list.IndexOf(lesson) + 1, lesson + "-Exercise");
                }
                else
                {
                    list.Add(lesson);
                    list.Add(lesson + "-Exercise");
                }
            }
            break;

        case "Swap":
            string theOtherlesson = arrComm[2];

            if (list.Contains(lesson) && list.Contains(theOtherlesson))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == lesson)
                    {
                        list[i] = theOtherlesson;
                    }
                    else if (list[i] == theOtherlesson)
                    {
                        list[i] = lesson;
                    }
                }
            }

            if (list.Contains(lesson + "-Exercise"))
            {
                list.Remove(lesson + "-Exercise");
                list.Insert(list.IndexOf(lesson) + 1, lesson + "-Exercise");
            }
            if (list.Contains(theOtherlesson + "-Exercise"))
            {
                list.Remove(theOtherlesson + "-Exercise");
                list.Insert(list.IndexOf(theOtherlesson) + 1, theOtherlesson + "-Exercise");
            }
            break;
    }

    command = Console.ReadLine();
}


for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("{0}.{1}", i + 1, list[i]);
}
