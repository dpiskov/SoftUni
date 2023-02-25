using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System;

namespace _3._Memory_game

{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            string input = Console.ReadLine();

            int numberOfMoves = 0;

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                numberOfMoves++;

                string[] index = input.Split();
                int firstIndex = int.Parse(index[0]);
                int secondIndex = int.Parse(index[1]);



                if (firstIndex  >= 0              &&
                    secondIndex >= 0              &&
                    firstIndex  <  sequence.Count &&
                    secondIndex <  sequence.Count &&
                    firstIndex  != secondIndex)
                {
                    if (sequence[firstIndex] == sequence[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            sequence.RemoveAt(firstIndex);
                            sequence.RemoveAt(secondIndex);
                        }
                        else
                        {
                            sequence.RemoveAt(secondIndex);
                            sequence.RemoveAt(firstIndex);
                        }

                        if (sequence.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (sequence[firstIndex] != sequence[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    sequence.Insert(sequence.Count / 2, $"-{numberOfMoves}a");
                    sequence.Insert(sequence.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                //Console.WriteLine(String.Join(" ", input));
                input = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", sequence));

        }

    }
}