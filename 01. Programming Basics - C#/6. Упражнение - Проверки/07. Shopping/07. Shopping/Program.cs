using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int memoryCount = int.Parse(Console.ReadLine());

            double gpuSum = gpuCount * 250;
            double cpuPrice = gpuSum * 0.35;
            double memoryPrice = gpuSum * 0.10;

            double totalSum = gpuSum + (cpuCount * cpuPrice) + (memoryCount * memoryPrice);

            if (gpuCount > cpuCount)
            {
                totalSum *= 0.85;
            }    

            if (totalSum <= budget)
            {
                Console.WriteLine($"You have {budget - totalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:F2} leva more!");
            }
        }
    }
}