using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCnt = int.Parse(Console.ReadLine());
            int roomsCnt = int.Parse(Console.ReadLine());

            for (int fl = floorsCnt; fl >= 1; fl--)
            {
                for (int room = 0; room < roomsCnt; room++)
                {
                    if (fl == floorsCnt)
                    {
                        Console.Write($"L{fl}{room} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{room} ");
                    }
                    else if (fl % 2 != 0)
                    {
                        Console.Write($"A{fl}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
