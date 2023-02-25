using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поздрав по име - решение

            /* 1. Курсорът остава на същия ред
            string name = Console.ReadLine();
            Console.Write("Hello, ");
            Console.Write(name);
            Console.WriteLine("!");
            */

            // 2. Долепяне 
            /*
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            */

            // 3.Интерполация
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}


