using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine()) * 5.80;
            double markers = double.Parse(Console.ReadLine()) * 7.20;
            double detergent = double.Parse(Console.ReadLine()) * 1.20;     
            double discount = double.Parse(Console.ReadLine()) / 100;

            double sum = pens + markers + detergent;
            double sumDisc = sum - (sum * discount);

            Console.WriteLine(sumDisc);
        }
    }
}