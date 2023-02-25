using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int birthdayMoney = 10;
            int sum = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += birthdayMoney;
                    birthdayMoney += 10;
                    sum--;
                }
                else
                {
                    sum += toyPrice;
                }
            }
            if (sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {sum - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - sum:f2}");
            }
        }
    }
}
