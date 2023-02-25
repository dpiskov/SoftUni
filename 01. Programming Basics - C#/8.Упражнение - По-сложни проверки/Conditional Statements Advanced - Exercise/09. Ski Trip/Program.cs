using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Вход
            //Първи ред -дни за престой -цяло число в интервала[0...365]
            //Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            //Трети ред -оценка - "positive"  или "negative"

            int days = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomPrice = 0;

            if (typeOfRoom == "room for one person")
            {
                roomPrice = 18.00 * days;
            }
            else if (typeOfRoom == "apartment")
            {
                roomPrice = 25.00 * days;

                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.30;
                }
                else if (days > 10 && days < 15)
                {
                    roomPrice -= roomPrice * 0.35;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.50;
                }
            }
            else //president apartment
            {
                roomPrice = 35.00 * days;

                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.10;
                }
                else if (days > 10 && days < 15)
                {
                    roomPrice -= roomPrice * 0.15;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.20;
                }
            }

            if (rating == "positive")
            {
                roomPrice += roomPrice * 0.25;
            }
            else
            {
                roomPrice -= roomPrice * 0.10;
            }

            Console.WriteLine($"{roomPrice:f2}");

            //"room for one person" – 18.00 лв за нощувка
            //"apartment" – 25.00 лв за нощувка
            //"president apartment" – 35.00 лв за нощувка
            //пример: 11 дни = 10 нощувки

            // Изход
            //•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.


        }
    }
}
