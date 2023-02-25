using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace _02._Shoot_FTW
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
            int shotTargets = 0;

            while (input != "End")
            {
                int index = int.Parse(input);
                int targetValue = 0;
                if (index >= 0 && index < targets.Count && targets[index] != -1)
                {
                    shotTargets++;
                    targetValue = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        else if (targets[i] > targetValue)
                        {
                            targets[i] -= targetValue;
                        }
                        else if (targets[i] <= targetValue && targets[i] != -1)
                        {
                            targets[i] += targetValue;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}