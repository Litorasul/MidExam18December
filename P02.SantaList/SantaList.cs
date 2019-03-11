using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SantaList
{
    class SantaList
    {
        static void Main(string[] args)
        {
            List<string> badKids = Console.ReadLine().Split("&").ToList();
            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                List<string> commandToList = command.Split().ToList();
                string toDo = commandToList[0];
                string name = commandToList[1];

                if (toDo == "Bad")
                {
                    if (!badKids.Contains(name))
                    {
                        badKids.Insert(0, name);
                    }

                }
                else if (toDo == "Good")
                {
                    if (badKids.Contains(name))
                    {
                        badKids.Remove(name);
                    }
                }
                else if (toDo == "Rename")
                {
                    string newName = commandToList[2];
                    if (badKids.Contains(name))
                    {
                        int index = badKids.IndexOf(name);
                        badKids.RemoveAt(index);
                        badKids.Insert(index, newName);
                    }
                }
                else if (toDo == "Rearrange")
                {
                    if (badKids.Contains(name))
                    {
                        int index = badKids.IndexOf(name);
                        badKids.RemoveAt(index);
                        badKids.Add(name);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", badKids));
        }
    }
}
