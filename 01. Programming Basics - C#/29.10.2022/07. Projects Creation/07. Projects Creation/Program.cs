using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            Console.WriteLine ($"The architect {name} will need {3 * projects} hours to complete {projects} project/s.");
        }
    }
}