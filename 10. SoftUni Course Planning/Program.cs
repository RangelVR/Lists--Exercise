using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            // в Judge дава 88/100.
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(":").ToArray();

            while (command[0] != "course start")
            {
                string subComma = command[0];
                string lesson = command[1];
                switch (subComma)
                {
                    case "Add":
                        if (!list.Contains(lesson))
                        {
                            list.Add(lesson);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (!list.Contains(lesson))
                        {
                            list.Insert(index, lesson);
                        }
                        break;

                    case "Remove":
                        list.Remove(lesson);
                        list.Remove(lesson + "-Exercise");
                        break;

                    case "Swap":
                        string theOtheLeson = command[2];
                        if (list.Contains(lesson) && list.Contains(theOtheLeson))
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == lesson)
                                {
                                    list[i] = theOtheLeson;
                                }
                                else if (list[i] == theOtheLeson)
                                {
                                    list[i] = lesson;
                                }
                            }
                        }
                        if (list.Contains(lesson + "-Exercise"))
                        {
                            list.RemoveAt(list.IndexOf(lesson + "-Exercise"));
                            list.Insert(list.IndexOf(lesson) + 1, lesson + "-Exercise");
                            
                        }
                        else if (list.Contains(theOtheLeson + "-Exercise"))
                        {
                            list.RemoveAt(list.IndexOf(theOtheLeson + "-Exercise"));
                            list.Insert(list.IndexOf(theOtheLeson) + 1, theOtheLeson + "-Exercise");
                        }
                        break;

                    case "Exercise":
                        if (list.Contains(lesson))
                        {
                            list.Insert(list.IndexOf(lesson) + 1, $"{lesson}-Exercise");
                        }
                        else if (!list.Contains(lesson))
                        {
                            list.Add(lesson);
                            list.Add($"{lesson}-Exercise");
                        }
                        break;

                }
                command = Console.ReadLine().Split(":").ToArray();
            }

            int counter = 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{counter}.{list[i]}");
                counter++;
            }
        }
    }
}
