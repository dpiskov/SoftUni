using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double pricesOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumbersOfSabers = Math.Ceiling(studentsCount * 1.10);
            double numberOfFreeBelts = Math.Floor(studentsCount / 6.0);

            double finalPriceOfSabers = totalNumbersOfSabers * pricesOfSaber;
            double finalPriceOfBelts = (studentsCount - numberOfFreeBelts) * priceOfBelts;
            double finalPriceOfRobes = studentsCount * priceOfRobes;

            double totalFinalPrice = finalPriceOfSabers + finalPriceOfBelts + finalPriceOfRobes;

            if (budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            }
            else
            {
                double moneyNeeded = Math.Abs(totalFinalPrice - budget);
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
