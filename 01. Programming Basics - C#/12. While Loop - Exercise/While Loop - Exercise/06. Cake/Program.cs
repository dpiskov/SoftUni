using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w * h;

            string input = Console.ReadLine();
            int cakePieces;

            while (input != "STOP")
            {
                cakePieces = int.Parse(input);

                if (cakePieces>cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces - cakeSize)} pieces more.");
                    cakeSize -= cakePieces;
                    break;
                }

                cakeSize -= cakePieces;

                input = Console.ReadLine();
            }

            if (cakeSize>0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }

        }
    }
}
