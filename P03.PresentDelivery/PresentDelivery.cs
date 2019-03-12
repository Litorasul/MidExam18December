using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.PresentDelivery
{
    class PresentDelivery
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int lastSantaLocation = 0;

            while (command != "Merry Xmas!")
            {
                List<string> commandtoList = command.Split().ToList();
                int numbersToJump = int.Parse(commandtoList[1]);

                int indexAfterJump = WhereIsSanta(numbersToJump, lastSantaLocation, houses);
                Console.WriteLine(indexAfterJump);
                lastSantaLocation = indexAfterJump;

                command = Console.ReadLine();
            }
        }

        private static int WhereIsSanta(int numbersToJump, int lastSantaLocation, List<int> houses)
        {
            int jump = lastSantaLocation + numbersToJump;

            if (jump < houses.Count)
            {
                return jump;
            }
            else
            {
                int fromTheStart = jump - houses.Count;
                return fromTheStart;
            }
        }
    }
}
