using System;
using System.Reflection;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.0;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                if (group == "Students")
                {
                    if (dayOfWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 10.46;
                    }

                    if (n >= 30)
                    {
                        sum = price * n;
                        sum *= 0.85;
                    }
                    else
                    {
                        sum = price * n;
                    }
                }
                else if (group == "Business")
                {
                    if (dayOfWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 16;
                    }

                    if (n >= 100)
                    {
                        sum = (price * n) - (10 * price);
                    }
                    else
                    {
                        sum = price * n;
                    }
                }
                else if (group == "Regular")
                {
                    if (dayOfWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 22.50;
                    }

                    if (n >= 10 && n <= 20)
                    {
                        sum = price * n;
                        sum *= 0.95;
                    }
                    else
                    {
                        sum = price * n;
                    }
                }
            }

            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}
