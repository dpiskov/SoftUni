using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                            .Split("!", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string item = string.Empty;

                //Urgent
                if (command[0] == "Urgent")
                {
                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (command[1] == groceries[i])
                        {
                            item = groceries[i];
                        }
                    }

                    if (command[1] == item)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, command[1]);
                    }
                }

                //Unnecessary
                if (command[0] == "Unnecessary")
                {
                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (command[1] == groceries[i])
                        {
                            groceries.Remove(command[1]);
                        }
                    }
                }

                //Correct
                if (command[0] == "Correct")
                {
                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (command[1] == groceries[i])
                        {
                            groceries.Insert(i, command[2]);
                            groceries.Remove(command[1]);
                        }
                    }
                }

                //Rearrange
                if (command[0] == "Rearrange")
                {
                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (command[1] == groceries[i])
                        {
                            groceries.RemoveAt(i);
                            groceries.Add(command[1]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", groceries));
        }
    }
}
