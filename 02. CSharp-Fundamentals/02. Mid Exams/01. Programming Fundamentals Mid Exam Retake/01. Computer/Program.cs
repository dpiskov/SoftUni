using System;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace _01._Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;

            while (input != "special" && input != "regular")
            {
                double money = double.Parse(input);

                if (money > 0)
                {
                    priceWithoutTaxes += money;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                input = Console.ReadLine();
            }

            double taxes = priceWithoutTaxes * 0.20;

            double finalPrice = priceWithoutTaxes + taxes;

            if (input == "special")
            {
                finalPrice -= finalPrice * 0.10;
            }

            if (finalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {finalPrice:f2}$");
        }
    }
}