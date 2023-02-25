using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                List<string> command = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //Collect
                if (command[0] == "Collect")
                {
                    bool exists = false;

                    for (int i = 0; i < items.Count; i++)
                    {
                        if (command[1] == items[i])
                        {
                            exists = true;
                        }
                    }

                    if (!exists)
                    {
                        items.Add(command[1]);
                    }
                }

                //Drop
                else if (command[0] == "Drop")
                {                    
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (command[1] == items[i])
                        {
                            items.Remove(command[1]);

                        }
                    }
                }

                //Combine Items
                else if (command[0] == "Combine Items")
                {
                    List<string> secondInput = command[1]
                        .Split(":", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    for (int i = 0; i < items.Count; i++)
                    {
                        if (secondInput[0] == items[i])
                        {
                            items.Insert(i + 1, secondInput[1]);
                        }
                    }
                }

                //Renew
                else if (command[0] == "Renew")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (command[1] == items[i])
                        {
                            string item = command[1];
                            items.Remove(command[1]);
                            items.Add(item);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
