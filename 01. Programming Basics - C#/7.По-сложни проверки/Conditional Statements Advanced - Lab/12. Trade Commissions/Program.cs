using System;
using System.Runtime.InteropServices;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500) commission = 0.05;
                if (sales > 500 && sales <= 1000) commission = 0.07;
                if (sales > 1000 && sales <= 10000) commission = 0.08;
                if (sales > 10000) commission = 0.12;
            }

            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500) commission = 0.045;
                if (sales > 500 && sales <= 1000) commission = 0.075;
                if (sales > 1000 && sales <= 10000) commission = 0.10;
                if (sales > 10000) commission = 0.13;
            }

            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500) commission = 0.055;
                if (sales > 500 && sales <= 1000) commission = 0.08;
                if (sales > 1000 && sales <= 10000) commission = 0.12;
                if (sales > 10000) commission = 0.145;
            }

            if ((sales < 0) || (town != "Sofia" && town != "Varna" && town != "Plovdiv"))
            {
                Console.WriteLine("error");
            }

            else
            {
                double profit = commission * sales;
                Console.WriteLine($"{profit:f2}");
            }

        }
    }
}