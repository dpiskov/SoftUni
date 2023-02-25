using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChicken = int.Parse(Console.ReadLine());
            int menuFish = int.Parse(Console.ReadLine());
            int menuVegetarian = int.Parse(Console.ReadLine());

            double priceChickenMenu = menuChicken * 10.35;
            double priceFishMenu = menuFish * 12.40;
            double priceVegetarianMenu = menuVegetarian * 8.15;

            double totalMenuSum = priceChickenMenu + priceFishMenu + priceVegetarianMenu;
            double priceDesert = totalMenuSum * 0.20;
            double totalSum = totalMenuSum + priceDesert + 2.50;

            Console.WriteLine(totalSum);
        }
    }
}