using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.00;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

                if (price != 0)
                {
                    Console.WriteLine($"{quantity * price:f2}");
                }


                //if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                //{
                //    if (fruit == "banana") price = quantity * 2.50;
                //    if (fruit == "apple") price = quantity * 1.20;
                //    if (fruit == "orange") price = quantity * 0.85;
                //    if (fruit == "grapefruit") price = quantity * 1.45;
                //    if (fruit == "kiwi") price = quantity * 2.70;
                //    if (fruit == "pineapple") price = quantity * 5.50;
                //    if (fruit == "grapes") price = quantity * 3.85;
                //    Console.WriteLine($"{price:F2}");
                //}
                //else if (day == "Saturday" || day == "Sunday")
                //{
                //    if (fruit == "banana") price = quantity * 2.70;
                //    if (fruit == "apple") price = quantity * 1.25;
                //    if (fruit == "orange") price = quantity * 0.90;
                //    if (fruit == "grapefruit") price = quantity * 1.60;
                //    if (fruit == "kiwi") price = quantity * 3.00;
                //    if (fruit == "pineapple") price = quantity * 5.60;
                //    if (fruit == "grapes") price = quantity * 4.20;
                //    Console.WriteLine($"{price:F2}");
                //}
                //else
                //{
                //    Console.WriteLine("error");
                //}


            }
        }
    }
