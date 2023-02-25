using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine("{0:F3}", area);
            }

            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine("{0:F3}", area);
            }

            if (figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                double area = Math.PI * (side*side);
                Console.WriteLine("{0:F3}", area);
            }

            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = (sideA * sideB) / 2;
                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}