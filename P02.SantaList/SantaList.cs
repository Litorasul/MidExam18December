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
                List<string> commandToList = command.Split().ToList;
                string toDO = commandToList[0];
                string name = commandToList[1];




                command = Console.ReadLine();
            }
        }
    }
}
