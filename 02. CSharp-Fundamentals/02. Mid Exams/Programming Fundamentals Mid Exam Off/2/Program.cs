using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            int blacklisted = 0;
            int lostNames = 0;

            while (input != "Report")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "Blacklist")
                {
                    if (!friends.Contains(command[1]))
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                        input = Console.ReadLine();
                        continue;
                    }

                    blacklisted++;

                    Console.WriteLine($"{command[1]} was blacklisted.");

                    int index = friends.IndexOf(command[1]);

                    friends[index] = "Blacklisted";
                }

                else if (command[0] == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < friends.Count)
                    {
                        if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                        {
                            lostNames++;

                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                        }
                    }                        
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < friends.Count)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {command[2]}.");
                        friends[index] = command[2];
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Blacklisted names: {blacklisted}");

            Console.WriteLine($"Lost names: {lostNames}");

            Console.WriteLine(String.Join(" ", friends));
        }
    }
}