using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double endPrice = 0.0;
            double endPrice2 = 0.0;
            double price = 0.0;
            double discount = 0.0;
            double increase = 0.0;



            if (flowers == "Roses")
            {
                price = 5;
                if (numberOfFlowers > 80)
                    discount = 0.10;
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice - (endPrice * discount);
            }

            if (flowers == "Dahlias")
            {
                price = 3.80;
                if (numberOfFlowers > 90)
                    discount = 0.15;
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice - (endPrice * discount);
            }

            if (flowers == "Tulips")
            {
                price = 2.80;
                if (numberOfFlowers > 80)
                    discount = 0.15;
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice - (endPrice * discount);
            }
            if (flowers == "Narcissus")
            {
                price = 3;
                if (numberOfFlowers < 120)
                    increase = 0.15;
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice + (endPrice * increase);
            }

            if (flowers == "Gladiolus")
            {
                price = 2.50;
                if (numberOfFlowers < 80)
                    increase = 0.20;
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice + (endPrice * increase);
            }

            if (flowers == "Roses" && flowers == "Dahlias" && flowers == "Tulips")
            {
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice - (endPrice * discount);
            }

            else if (flowers == "Narcissus" && flowers == "Gladiolus")
            {
                endPrice = numberOfFlowers * price;
                endPrice2 = endPrice + (endPrice * increase);
            }

            double neededMoney = budget - endPrice2;

            if (neededMoney >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {budget - endPrice2:f2} leva left.");
            }
            else if (neededMoney < 0)
            {
                neededMoney = Math.Abs(neededMoney);
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}










//if (flowers == "Roses")
//{
//    price = 5;
//    if (numberOfFlowers > 80)
//    {
//        discount = 0.10;
//    }
//    else
//    {
//        discount = 0;
//    }
//}

//if (flowers == "Dahlias")
//{
//    price = 3.80;
//    if (numberOfFlowers > 90)
//    {
//        discount = 0.15;
//    }
//    else
//    {
//        discount = 0;
//    }
//}

//if (flowers == "Tulips")
//{
//    price = 2.80;
//    if (numberOfFlowers > 80)
//    {
//        discount = 0.15;
//    }
//    else
//    {
//        discount = 0;
//    }
//}
//if (flowers == "Narcissus")
//{
//    price = 3;
//    if (numberOfFlowers < 120)
//    {
//        increase = 0.15;
//    }
//    else
//    {
//        increase = 0;
//    }
//}


//if (flowers == "Gladiolus")
//{
//    price = 2.50;
//    if (numberOfFlowers < 80)
//    {
//        increase = 0.20;
//    }
//    else
//    {
//        increase = 0;
//    }
//}

//if (flowers == "Roses" && flowers == "Dahlias" && flowers == "Tulips")
//{
//    endPrice = numberOfFlowers * price;
//    endPrice2 = endPrice - (endPrice * discount);
//}

//else if (flowers == "Narcissus" && flowers == "Gladiolus")
//{
//    endPrice = numberOfFlowers * price;
//    endPrice2 = endPrice + (endPrice * increase);
//}

//Console.WriteLine(endPrice);
//Console.WriteLine(endPrice2);

//if (budget > endPrice2)
//{
//    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {budget - endPrice2:f2} leva left.");
//}
//else if (budget < endPrice2)
//{
//    double neededMoney = Math.Abs(endPrice2 - budget);
//    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
//}