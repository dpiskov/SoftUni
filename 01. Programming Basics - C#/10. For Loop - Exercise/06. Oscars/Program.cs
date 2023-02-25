using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Точките, които актьора получава се формират от: дължината на името на оценяващия умножено по точките, които дава делено на две. 
            //Ако резултатът в някой момент надхвърли 1250.5 програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.

            //Вход
            //•	Име на актьора - текст
            //•	Точки от академията - реално число в интервала[2.0... 450.5]
            //•	Брой оценяващи n - цяло число в интервала[1… 20]
            //На следващите n - на брой реда:
            //o Име на оценяващия -текст
            //o Точки от оценяващия -реално число в интервала[1.0... 50.0]

            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string reviewer = string.Empty;
            double ratings;
            //double sum = 0;

            for (int i = 0; i < n; i++)
            {
                reviewer = Console.ReadLine();
                ratings = double.Parse(Console.ReadLine());

                int nameLength = reviewer.Length;

                points += (nameLength * ratings) / 2;

                if (points > 1250.5)
                {
                    break;
                }
            }

            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(1250.5 - points):f1} more!");
            }
            
            //Изход
            //Да се отпечата на конзолата един ред:
            //•	Ако точките са над 1250.5:
            //"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
            //•	Ако точките не са достатъчни:
            //            "Sorry, {име на актьора} you need {нужни точки} more!"
            //Резултатът да се форматирана до първата цифра след десетичния знак!

        }
    }
}
