using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //input
            double dollars = double.Parse(Console.ReadLine());
            
            //calculations
            double rate = 1.79549;
            double bgn = dollars * rate;

            //output
            Console.WriteLine(bgn);
        }
    }
}