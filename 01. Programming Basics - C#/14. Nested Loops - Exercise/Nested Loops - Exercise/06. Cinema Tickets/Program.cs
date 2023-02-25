using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int free;
            int tickets;

            int kidTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;

            string type;

            while (input != "Finish")
            {
                free = int.Parse(Console.ReadLine());
                tickets = 0;

                type = Console.ReadLine();

                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    tickets++;

                    if (tickets >= free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                Console.WriteLine($"{input} - {(free - tickets) / 0.10}% full.");

                input = Console.ReadLine();

            }

            int totalTickets = studentTickets + standardTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(totalTickets - studentTickets) / 0.10}% student tickets.");
            Console.WriteLine($"{(totalTickets - standardTickets) / 0.10}% standard tickets.");
            Console.WriteLine($"{(totalTickets - kidTickets) / 0.10}% kids tickets.");
        }
    }
}
