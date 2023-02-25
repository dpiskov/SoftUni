using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalArea = double.Parse(Console.ReadLine());
            double totalPrice = totalArea * 7.61;
            double discount = 0.18 * totalPrice;
            double finalPrice = totalPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The final discount is: {discount}");
        }
    }
}