using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Предпазен найлон - 1.50 лв. за кв. метър
            //· Боя - 14.50 лв. за литър
            // · Разредител за боя - 5.00 лв. за литър

            //    За всеки случай, към необходимите материали, 
            //    Румен иска да добави още 10 % от количеството боя и 2 кв.м.найлон, 
            //    разбира се и 0.40 лв.за торбички. 
            //    Сумата, която се заплаща на майсторите за 1 час работа, е 
            //    равна на 30 % от сбора на всички разходи за материали.

            //    Входът се чете от конзолата и съдържа точно 4 реда:

            //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]
            //3.Количество разредител(в литри) - цяло число в интервала[1…30]
            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]

            //Сума за найлон: (10 + 2) * 1.50 = 18 лв.
            //Сума за боя: (11 + 10 %) * 14.50 = 175.45 лв.
            //Сума за разредител: 4 * 5.00 = 20.00 лв.
            //Сума за торбички: 0.40 лв.
            //Обща сума за материали: 18 + 175.45 + 20.00 + 0.40 = 213.85 лв.
            //Сума за майстори: (213.85 * 30 %) * 8 = 513.24 лв.
            //Крайна сума: 213.85 + 513.24 = 727.09 лв.


            int nylon = int.Parse(Console.ReadLine()) + 2;
            int paintInLitres = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workHours = int.Parse (Console.ReadLine());

            double sumNylon = nylon * 1.50;
            double sumPaint = (paintInLitres + (paintInLitres * 0.1)) * 14.50;
            double sumDiluent = diluent * 5.00;

            double sumMat = sumNylon + sumPaint + sumDiluent + 0.40;
            double sumWorkers = (sumMat * 0.3) * workHours;
            double sum = sumMat + sumWorkers;

            Console.WriteLine(sum);

        }
    }
}