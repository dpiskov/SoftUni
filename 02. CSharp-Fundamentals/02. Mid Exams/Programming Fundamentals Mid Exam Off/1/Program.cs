using System;

namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactory = int.Parse(Console.ReadLine());

            int days = 0;

            double totalProd = 0;

            while (days < 30)
            {
                days++;

                double prodEveryDay = biscuitsPerWorker * countOfWorkers;


                if (days % 3 == 0)
                {
                    prodEveryDay = Math.Floor(prodEveryDay * 0.75);
                }

                totalProd += prodEveryDay;

            }

            int difference = (int)totalProd - competingFactory;
            double percentage = (1.0 * difference / competingFactory) * 100;
            percentage = Math.Abs(percentage);

            Console.WriteLine($"You have produced {totalProd} biscuits for the past month.");


            if (totalProd > competingFactory)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else if (totalProd < competingFactory)
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
