using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //През годината Гришо участва в определен брой турнири, като за всеки турнир получава точки, които зависят от позицията, на която е завършил в турнира.
            //Има три варианта за завършване на турнир:
            //	W - ако е победител получава 2000 точки
            //	F - ако е финалист получава 1200 точки
            //	SF - ако е полуфиналист получава 720 точки
            //Напишете програма, която изчислява колко ще са точките на Григор след изиграване на всички турнири, като знаете с колко точки стартира сезона.
            //Също изчислете колко точки средно печели от всички изиграни турнири и колко процента от турнирите е спечелил.
            //Вход
            //От конзолата първо се четат два реда:
            //•	Брой турнири, в които е участвал – цяло число в интервала[1…20] 
            //•	Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            //За всеки турнир се прочита отделен ред:
            //•	Достигнат етап от турнира – текст – "W", "F" или "SF"

            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            string checkpoint = string.Empty;
            int wonPoints = 0;
            int wonMents = 0;

            for (int i = 0; i < tournaments; i++)
            {
                checkpoint = Console.ReadLine();

                switch (checkpoint)
                {
                    case "W": wonPoints += 2000; wonMents++; break;
                    case "F": wonPoints += 1200; break;
                    case "SF": wonPoints += 720; break;
                }

            }
            int totalPoints = startingPoints + wonPoints;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(wonPoints * 1.0 / tournaments)}");
            Console.WriteLine($"{(wonMents * 1.0 / tournaments) * 100:f2}%");

            //Изход
            //Отпечатват се три реда в следния формат:
            //•	"Final points: {брой точки след изиграните турнири}"
            //•	"Average points: {средно колко точки печели за турнир}"
            //•	"{процент спечелени турнири}%"
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу, а процентът да се форматира до втората цифра след десетичния знак.

        }
    }
}
