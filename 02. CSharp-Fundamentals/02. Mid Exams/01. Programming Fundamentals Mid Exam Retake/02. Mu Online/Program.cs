using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Mu_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initHealth = 100;
            int bitcoins = 0;

            int count = 0;

            List<string> input = Console.ReadLine()
                .Split("|")
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> room = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                //potion
                if (room[0] == "potion")
                {
                    count++;

                    int health = int.Parse(room[1]);
                    int healedFor = 0;

                    if (initHealth + health > 100 && health >= 100 - initHealth)
                    {
                        healedFor = 100 - initHealth;
                        initHealth += healedFor;
                    }
                    else
                    {
                        healedFor = health;
                        initHealth += healedFor;
                    }

                    Console.WriteLine($"You healed for {healedFor} hp.");
                    Console.WriteLine($"Current health: {initHealth} hp.");
                }

                //chest
                else if (room[0] == "chest")
                {
                    count++;

                    int amount = int.Parse(room[1]);

                    bitcoins += amount;

                    Console.WriteLine($"You found {amount} bitcoins.");
                }

                //other
                else
                {
                    count++;

                    int power = int.Parse(room[1]);

                    initHealth -= power;

                    if (initHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        Console.WriteLine($"Best room: {count}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {room[0]}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initHealth}");
        }
    }
}
