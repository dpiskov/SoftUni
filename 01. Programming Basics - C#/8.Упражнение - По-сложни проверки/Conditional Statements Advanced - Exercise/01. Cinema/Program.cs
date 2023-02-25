using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticket = 0;
            if (projection == "Premiere")
            {
                ticket = 12.00;
            }
            else if (projection == "Normal")
            {
                ticket = 7.50;
            }
            else if (projection == "Discount")
            {
                ticket = 5.00;
            }

            double income = rows * columns * ticket;
            Console.WriteLine("{0:f2} leva", income);

        }
    }
}