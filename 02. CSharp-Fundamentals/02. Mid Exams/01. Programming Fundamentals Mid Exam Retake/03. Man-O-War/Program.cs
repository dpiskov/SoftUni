using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> statusOfShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> statusOfWarship = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Retire!")
            {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "Fire")
                {
                    //"Fire {index} {damage}" - the pirate ship attacks the warship with the given damage at that section. Check if the index is valid and if not, skip the command.If the section breaks(health <= 0) the warship sinks, print the following and stop the program: "You won! The enemy ship has sunken."

                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);

                    if (index > 0 && index < statusOfWarship.Count)
                    {
                        statusOfWarship[index] -= damage;

                        if (statusOfWarship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }

                else if (command[0] == "Defend")
                {
                    //"Defend {startIndex} {endIndex} {damage}" - the warship attacks the pirate ship with the given damage at that range(indexes are inclusive). Check if both indexes are valid and if not, skip the command.If the section breaks(health <= 0) the pirate ship sinks, print the following and stop the program: "You lost! The pirate ship has sunken."

                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);

                    if (startIndex >= 0 &&
                        startIndex < statusOfShip.Count &&
                        endIndex > 0 &&
                        endIndex < statusOfShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            statusOfShip[i] -= damage;

                            if (statusOfShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }



                    else if (command[0] == "Repair")
                    {
                        //"Repair {index} {health}" - the crew repairs a section of the pirate ship with the given health. Check if the index is valid and if not, skip the command.The health of the section cannot exceed the maximum health capacity.

                        int index = int.Parse(command[1]);
                        int health = int.Parse(command[2]);

                        if (index > 0 && index < statusOfShip.Count)
                        {
                            if (statusOfShip[index] + health !> maxHealth)
                            {
                                statusOfShip[index] += health;
                            }
                        }

                    }
                    else if (command[0] == "Status")
                    {
                        //"Status" - prints the count of all sections of the pirate ship that need repair soon, which are all sections that are lower than 20 % of the maximum health capacity. Print the following: "{count} sections need repair."
                    }


                    //In the end, if a stalemate occurs, print the status of both ships, which is the sum of their individual sections, in the following format: "Pirate ship status: {pirateShipSum} Warship status: { warshipSum}"




                    input = Console.ReadLine();
                }
            }

        }
    }
}