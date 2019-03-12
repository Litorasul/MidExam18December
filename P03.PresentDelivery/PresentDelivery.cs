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

                if (houses[indexAfterJump] > 2)
                {
                    houses[indexAfterJump] -= 2;
                }
                else if (houses[indexAfterJump] <= 2 && houses[indexAfterJump] != 0)
                {
                    houses[indexAfterJump] = 0;
                }
                else
                {   
                    Console.WriteLine($"House {indexAfterJump} will have a Merry Christmas.");
                }
                
                lastSantaLocation = indexAfterJump;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {lastSantaLocation}.");
            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int housesFailed = HousesNotZero(houses);
                Console.WriteLine($"Santa has failed {housesFailed} houses.");
            }
        }

        private static int HousesNotZero(List<int> houses)
        {
            int notZero = 0;
            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] != 0)
                {
                    notZero++;
                }
            }
            return notZero;
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
