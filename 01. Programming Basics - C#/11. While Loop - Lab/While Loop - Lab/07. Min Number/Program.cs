using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;


            int minNumber = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
