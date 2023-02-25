using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //"Add - {phone}"
                if (command[0] == "Add")
                {
                    if (phones.Contains(command[1]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    phones.Add(command[1]);
                }

                //"Remove - {phone}"
                else if (command[0] == "Remove")
                {
                    if (phones.Contains(command[1]))
                    {
                        phones.Remove(command[1]);
                    }
                }

                //"Bonus phone - {oldPhone}:{newPhone}"
                else if (command[0] == "Bonus phone")
                {
                    List<string> splitPhones = command[1]
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    if (phones.Contains(splitPhones[0]))
                    {
                        if (splitPhones[0] != splitPhones[1])
                        {
                            int index = phones.IndexOf(splitPhones[0]);
                            phones.Insert(index + 1, splitPhones[1]);
                        }
                    }
                }

                //"Last - {phone}"
                else if (command[0] == "Last")
                {
                    if (phones.Contains(command[1]))
                    {
                        //string element = command[1];
                        phones.Remove(command[1]);

                        phones.Add(command[1]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
