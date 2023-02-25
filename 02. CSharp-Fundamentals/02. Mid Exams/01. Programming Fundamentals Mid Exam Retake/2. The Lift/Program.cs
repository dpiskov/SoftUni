using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] < 4)
                {
                    if (people >= 4 - wagons[i])
                    {
                        people -= 4 - wagons[i];
                        wagons[i] = 4;
                    }
                    else
                    {
                        wagons[i] += people;
                        people = 0;
                    }
                }
            }

            bool isNotFull = false;

            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] < 4)
                {
                    isNotFull = true;
                    break;
                }
            }

            if (people == 0 && isNotFull)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0 && !isNotFull)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }


            Console.WriteLine(String.Join(' ', wagons));
        }
    }
}