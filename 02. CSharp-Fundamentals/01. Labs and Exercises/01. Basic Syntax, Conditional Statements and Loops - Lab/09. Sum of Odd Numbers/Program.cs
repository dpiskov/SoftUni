using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = 1 + (i * 2);              
                Console.WriteLine(currentNumber);
                sum += currentNumber;
            }
                Console.WriteLine($"Sum: {sum}");

        }
    }
}
