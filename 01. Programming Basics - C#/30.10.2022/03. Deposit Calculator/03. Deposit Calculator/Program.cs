using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            1. Депозирана сума – реално число в интервала [100.00 … 10000.00]
            2. Срок на депозита (в месеци) – цяло число в интервала [1…12]
            3. Годишен лихвен процент – реално число в интервала [0.00 …100.00]
            */

            double depSuma = double.Parse(Console.ReadLine());
            int depSrok = int.Parse(Console.ReadLine());
            double godProcent = double.Parse(Console.ReadLine()) / 100;

            double suma = depSuma + depSrok * ((depSuma * (godProcent /* / 100 */) / 12));
            Console.WriteLine(suma);


        }
    }
}