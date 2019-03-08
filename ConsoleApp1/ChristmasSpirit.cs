using System;

namespace ConsoleApp1
{
    class ChristmasSpirit
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int daysUntilChristmas = int.Parse(Console.ReadLine());

            long ornamentSet = 2;
            long treeSkirt = 5;
            long treeGarlands = 3;
            long treeLights = 15;
            long christmasSpirit = 0;
            long budget = 0;

            for (int day = 1; day <= daysUntilChristmas; day++)
            {
                if (day % 11 == 0)
                {
                    quantity += 2;
                }

                if (day % 2 == 0)
                {
                    budget += ornamentSet * quantity;
                    christmasSpirit += 5;
                }

                if (day % 3 == 0)
                {
                    budget += (treeSkirt * quantity) + (treeGarlands * quantity);
                    christmasSpirit += 13;
                }

                if (day % 5 == 0)
                {
                    budget += treeLights * quantity;
                    christmasSpirit += 17;

                    if (day % 3 == 0)
                    {
                        christmasSpirit += 30;
                    }
                }

                if (day % 10 == 0)
                {
                    christmasSpirit -= 20;
                    budget += treeSkirt + treeGarlands + treeLights;
                    if (day == daysUntilChristmas)
                    {
                        christmasSpirit -= 30;
                    }
                }
            }

            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");

        }
    }
}
