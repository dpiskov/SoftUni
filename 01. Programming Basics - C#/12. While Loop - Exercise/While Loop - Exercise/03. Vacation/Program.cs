﻿using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendCount = 0;

            string input;
            double money;

            while (availableMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                daysCount++;

                if (input == "save")
                {
                    availableMoney += money;

                    spendCount = 0;
                }
                else
                {
                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    spendCount++;

                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
            }

            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }

        }
    }
}
