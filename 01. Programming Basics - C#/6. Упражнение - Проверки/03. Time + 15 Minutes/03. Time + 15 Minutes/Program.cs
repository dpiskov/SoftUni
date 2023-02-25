using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TO-DO:
            Лимит на часовете до 24
            Лимит на минутите до 59
            Преобразуване на минути над 59 в час
            + 15 минути от въведените

            */

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;
            int newHours = hours;

            if (newMinutes >= 60)
            {
                newHours = hours + 1;
                newMinutes = newMinutes % 60;
            }
            else
            {
                newHours = hours;
            }

            if (newHours >= 24)
            {
                newHours = newHours % 24;
            }


            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}