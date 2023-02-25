using System;
using System.Reflection;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int capacity = width * height * length;

            string input;
            int box = 0;

            while ((input = Console.ReadLine()) != "Done")
            {            
                box += int.Parse(input);

                if (box >= capacity)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(box - capacity)} Cubic meters more.");
                    break;
                }
               
            }
            if (capacity >= box)
            {
                Console.WriteLine($"{Math.Abs(capacity - box)} Cubic meters left.");
            }

        }
    }
}
