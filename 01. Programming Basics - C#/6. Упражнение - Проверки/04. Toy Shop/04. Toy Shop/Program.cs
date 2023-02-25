using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());

            //Toys
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double discount = 0;
            double money = 0;
            double endPrice = 0;

            double sum = puzzle * 2.60 + dolls * 3 + bear * 4.10 + minions * 8.20 + trucks * 2;
            double numberOfToys = puzzle + dolls + bear + minions + trucks;

            if (numberOfToys >= 50)
            {
                discount = sum * 0.25;
                endPrice = sum - discount;
            }
            else if (numberOfToys < 50)
            {
                discount = 0.0;
                endPrice = sum - discount;
            }
        
            double rent = endPrice * 0.10;
            double profit = endPrice - rent;
            double difference = Math.Abs(profit - priceTrip);

            if (profit >= priceTrip)
            {
                money = profit - priceTrip;
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else if (profit < priceTrip)
            {
                money = priceTrip - profit;
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }

        }
    }
}