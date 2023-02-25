using System;
using System.Linq;
using System.Collections.Generic;


namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int index = int.Parse(command[1]);

                //Shoot
                if (command[0] == "Shoot")
                {
                    int power = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }

                //Add
                else if (command[0] == "Add")
                {
                    int value = int.Parse(command[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                //Strike
                else if (command[0] == "Strike")
                {
                    int radius = int.Parse(command[2]);

                    if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                    {
                        //First option:
                        //targets.RemoveRange(index - radius, radius * 2 + 1);

                        //Second option:
                        while (radius >= 1)
                        {
                            targets.RemoveAt(index + radius);
                            targets.RemoveAt(index - radius);
                            radius--;
                        }
                        targets.RemoveAt(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}