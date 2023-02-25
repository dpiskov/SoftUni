using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodDog = int.Parse(Console.ReadLine());
            int foodCat = int.Parse(Console.ReadLine());
            double priceDog = foodDog * 2.50;
            double priceCat = foodCat * 4;
            double result = priceDog + priceCat;
            Console.WriteLine(result + " lv.");
        }
    }
}