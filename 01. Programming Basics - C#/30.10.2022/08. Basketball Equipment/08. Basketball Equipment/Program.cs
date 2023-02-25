using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyPrice = int.Parse(Console.ReadLine());

            double priceSneakers = yearlyPrice - (yearlyPrice * 0.40);
            double priceJersey = priceSneakers - (priceSneakers * 0.20);
            double priceBall = priceJersey / 4;
            double priceAccesories = priceBall / 5;
            double priceTotal = yearlyPrice + priceSneakers + priceJersey + priceBall + priceAccesories;

            Console.WriteLine(priceTotal);

        }
    }
}