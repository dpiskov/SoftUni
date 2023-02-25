﻿using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double price = 0;

            //Body

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.30;
                }
                else
                {
                    place = "Hotel";
                    price = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.40;
                }
                else
                {
                    place = "Hotel";
                    price = budget * 0.80;
                }
            }
            else // budget > 1000
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.90;
            }

            //Output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");

        }
    }
}
