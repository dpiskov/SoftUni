using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> topFive = new List<int>();

            bool isGreater = false;

            int count = numbers.Count;
            int sum = 0;
            double average = 0;

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
                average = 1.0 * sum / count;
            }

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > average)
                {
                    topFive.Add(numbers[i]);
                    isGreater = true;
                }
            }

            topFive.Sort();

            while (topFive.Count > 5)
            {
                topFive.RemoveAt(0);
            }

            topFive.Reverse();

            if (!isGreater)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topFive));

            }
        }
    }
}