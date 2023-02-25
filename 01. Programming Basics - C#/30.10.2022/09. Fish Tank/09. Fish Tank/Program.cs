using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacityAquarium = length * width * height;
            double capacityLitres = capacityAquarium * 0.001;
            double capacityOccupied = percent / 100;
            double capacityNeeded = capacityLitres * (1 - (1 * capacityOccupied));

            Console.WriteLine(capacityNeeded);

        }
    }
}