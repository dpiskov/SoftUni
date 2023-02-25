using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace _01._CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initEnergy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int count = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (initEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initEnergy} energy");
                    return;
                }

                count++;
                initEnergy -= distance;

                if (count % 3 == 0)
                {
                    initEnergy += count;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {count}. Energy left: {initEnergy}");
        }
    }
}