using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double metersEverySec = double.Parse(Console.ReadLine());

            double goal = distanceMeters * metersEverySec;
            double delay = Math.Floor(distanceMeters / 15) * 12.5;
            double totalTime = goal + delay;

            if (recordSec > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double notEnough = Math.Abs(totalTime - recordSec);
                Console.WriteLine($"No, he failed! He was {notEnough:F2} seconds slower.");
            }      
        }
    }
}