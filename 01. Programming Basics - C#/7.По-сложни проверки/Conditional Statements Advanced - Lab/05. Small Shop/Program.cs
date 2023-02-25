using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (town == "Sofia")
            {
                if (productName == "coffee") price = quantity * 0.50;
                if (productName == "water") price = quantity * 0.80;
                if (productName == "beer") price = quantity * 1.20;
                if (productName == "sweets") price = quantity * 1.45;
                if (productName == "peanuts") price = quantity * 1.60;
            }
            if (town == "Plovdiv")
            {
                if (productName == "coffee") price = quantity * 0.40;
                if (productName == "water") price = quantity * 0.70;
                if (productName == "beer") price = quantity * 1.15;
                if (productName == "sweets") price = quantity * 1.30;
                if (productName == "peanuts") price = quantity * 1.50;
            }
            if (town == "Varna")
            {
                if (productName == "coffee") price = quantity * 0.45;
                if (productName == "water") price = quantity * 0.70;
                if (productName == "beer") price = quantity * 1.10;
                if (productName == "sweets") price = quantity * 1.35;
                if (productName == "peanuts") price = quantity * 1.55;
            }
            Console.WriteLine(price);
        }
    }
}