using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;

            // Seasons
            if (season == "Spring")
            {
                price = 3000;
            }          
            else if (season == "Summer")
            {
                price = 4200;
            }
            else if (season == "Autumn")
            {
                price = 4200;
            }
            else
            {
                price = 2600;
            }

            //Discounts

            if (fishermen <= 6)
            {
                price -= price * 0.10;
            }
            else if (fishermen <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }

            //Bonus Discount

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");            
            }
        }
    }
}