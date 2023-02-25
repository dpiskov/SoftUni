using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _3._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfHearts = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            int lastIndex = 0;
            int lastTurnIndex = 0;

            while (input != "Love!")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


                int index = int.Parse(command[1]);

                if (command[0] == "Jump")
                {
                    if (lastTurnIndex + index >= numberOfHearts.Count)
                    {
                        lastTurnIndex = 0;
                        numberOfHearts[0] -= 2;

                        if (numberOfHearts[lastTurnIndex] < 0)
                        {
                            Console.WriteLine($"Place {lastTurnIndex} already had Valentine's day.");
                        }
                    }
                    else
                    {
                        numberOfHearts[lastTurnIndex + index] -= 2;

                        if (numberOfHearts[lastTurnIndex + index] < 0)
                        {
                            Console.WriteLine($"Place {lastTurnIndex + index} already had Valentine's day.");
                        }

                        lastTurnIndex += index;                 
                    }

                    if (numberOfHearts[lastTurnIndex] == 0)
                    {
                        Console.WriteLine($"Place {lastTurnIndex} has Valentine's day.");
                    }
                }

                lastIndex = lastTurnIndex;

                input = Console.ReadLine();
            }

            bool failed = false;
            int failCount = 0;

            for (int i = 0; i < numberOfHearts.Count; i++)
            {
                if (numberOfHearts[i] > 0)
                {
                    failed = true;
                    failCount++;
                }
            }

            Console.WriteLine($"Cupid's last position was {lastIndex}.");

            if (failed)
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}