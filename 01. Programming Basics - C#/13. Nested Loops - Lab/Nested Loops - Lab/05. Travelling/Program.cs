using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            int savedMoney = 0;
            int money = 0;


            while ((destination = Console.ReadLine()) != "End")
            {
                int neededMoney = int.Parse(Console.ReadLine());

                while (money < neededMoney)
                {
                    savedMoney = int.Parse(Console.ReadLine());
                    money += savedMoney;
                }

                if (money >= neededMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                    money=0;
                }

            }

        }
    }
}
