using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


                //Loot
                if (command.Count > 2)
                {
                    if (command[0] == "Loot")
                    {
                        bool exists = false;

                        for (int i = 1; i < command.Count; i++)
                        {
                            for (int j = 0; j < initChest.Count; j++)
                            {
                                if (command[i] == initChest[j])
                                {
                                    exists = true;
                                    break;
                                }
                            }

                            if (!exists)
                            {
                                initChest.Insert(0, command[i]);
                            }
                            exists = false;

                        }

                    }
                }

                else if (command.Count == 2)
                {

                    //Drop
                    if (command[0] == "Drop")
                    {
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index <= initChest.Count)
                        {
                            string item = initChest[index];
                            initChest.RemoveAt(index);
                            initChest.Add(item);
                        }
                    }

                    //Steal
                    else if (command[0] == "Steal")
                    {
                        int count = int.Parse(command[1]);

                        List<string> stolenItems = new List<string>();

                        if (count >= 0 && count <= initChest.Count && initChest.Count - count >= 0)
                        {
                            while (count > 0)
                            {
                                stolenItems.Add(initChest[initChest.Count - count]);
                                initChest.RemoveAt(initChest.Count - count);
                                count--;
                            }
                        }

                        Console.WriteLine(String.Join(", ", stolenItems));
                    }
                }

                input = Console.ReadLine();
            }
           
            if (initChest.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < initChest.Count; i++)
                {
                    sum += initChest[i].Length;
                }

                double averageGain = 1.0 * sum / initChest.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
