using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;
            int num;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            int num2 = sum - maxNumber;

            if (num2 == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {num2}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(num2 - maxNumber)}");
            }

        }
    }
}
