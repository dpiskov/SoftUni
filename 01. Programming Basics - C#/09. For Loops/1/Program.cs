using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Числата от N до 1 в обратен ред
            //int n = int.Parse(Console.ReadLine());

            //for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Числата от 1 до N през 3
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Четни степени на 2
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;
            //for (int i = 0; i <= n; i += 2)
            //{
            //    Console.WriteLine(num);
            //    num = num * 2 * 2;
            //}

            //Не работи
            //string text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.Write(text[i]);
            //}

            //Сумиране на гласни букви
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
            }
            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}
