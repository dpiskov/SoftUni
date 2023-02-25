using System;
using System.Collections.Generic;
using System.Drawing;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodInKilograms = double.Parse(Console.ReadLine());
            double hayInKilograms = double.Parse(Console.ReadLine());
            double coverInKilograms = double.Parse(Console.ReadLine());
            double weightInKilograms = double.Parse(Console.ReadLine());

            double foodInGrams = foodInKilograms * 1000;
            double hayInGrams = hayInKilograms * 1000;
            double coverInGrams = coverInKilograms * 1000;
            double weightInGrams = weightInKilograms * 1000;

            int days = 0;
            int firstCount = 0;
            int secondCount = 0;

            while (days < 30)
            {
                days++;
                firstCount++;
                secondCount++;

                foodInGrams -= 300;

                if (firstCount == 2)
                {
                    hayInGrams -= foodInGrams * 0.05;
                    firstCount = 0;
                }

                if (secondCount == 3)
                {
                    coverInGrams -= weightInGrams / 3;
                    secondCount = 0;
                }

                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams/1000:f2}, Hay: {hayInGrams/1000:f2}, Cover: {coverInGrams/1000:f2}.");
        }
    }
}