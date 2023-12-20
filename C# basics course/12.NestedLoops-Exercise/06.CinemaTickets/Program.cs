using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;
            int kidsTicketsCount = 0;
            int totalTicketsCount = 0;
            string movieName = Console.ReadLine();
            while (movieName != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                int soldTickets = 0;
                
                string ticketType = Console.ReadLine();
                while (ticketType != "End") 
                {
                    if (ticketType == "student")
                    {
                        studentTicketsCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketsCount++;
                    }
                    else if (ticketType == "kid") 
                    {
                        kidsTicketsCount++;
                    }

                    soldTickets++;
                    if (soldTickets == capacity) 
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                totalTicketsCount += soldTickets;

                double fillPercentage = 100.0 * soldTickets / capacity;
                Console.WriteLine($"{movieName} - {fillPercentage:F2}% full.");

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{100.0 * studentTicketsCount / totalTicketsCount:F2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTicketsCount / totalTicketsCount:F2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidsTicketsCount / totalTicketsCount:F2}% kids tickets.");
        }
    }
}
