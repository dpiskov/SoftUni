using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            //int number;

            int maxNumber = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
