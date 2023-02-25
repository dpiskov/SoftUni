using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Stop")
                {
                    break;
                }

                Console.WriteLine(name);
            }
        }
    }
}
