using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceStatistsClothes = double.Parse(Console.ReadLine());

            double discount = 0;

            double sumDecor = budget * 0.10;
            double sumClothes = statists * priceStatistsClothes;

            if (statists >= 150)
            {
                discount = sumClothes * 0.10;
            }

            sumClothes = sumClothes - discount;
            double moviePrice = sumDecor + sumClothes;

            if (moviePrice > budget)
            {
                double moneyChange = moviePrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyChange:F2} leva more.");
            }
            else
            {
                double moneyChange = budget - moviePrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyChange:F2} leva left.");
            }
        }
    }
}