using System;
using System.Text;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            //Тяло
            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
                else if (nights > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else //July and August
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;

                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }

            // Изход
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
