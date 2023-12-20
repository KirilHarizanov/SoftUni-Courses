using System;

namespace _3.SnookerTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stageInTournament = Console.ReadLine();
            string typeOfTicket = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            string photoWithTrophy = Console.ReadLine();

            double priceOfTicket = 0;

            if (typeOfTicket == "Standard")
            {
                if (stageInTournament == "Quarter final")
                {
                    priceOfTicket = 55.50;
                }
                else if (stageInTournament == "Semi final")
                {
                    priceOfTicket = 75.88;
                }
                else if (stageInTournament == "Final")
                {
                    priceOfTicket = 110.10;
                }
            }
            else if (typeOfTicket == "Premium")
            {
                if (stageInTournament == "Quarter final")
                {
                    priceOfTicket = 105.20;
                }
                else if (stageInTournament == "Semi final")
                {
                    priceOfTicket = 125.22;
                }
                else if (stageInTournament == "Final")
                {
                    priceOfTicket = 160.66;
                }
            }
            else if (typeOfTicket == "VIP") 
            {
                if (stageInTournament == "Quarter final")
                {
                    priceOfTicket = 118.90;
                }
                else if (stageInTournament == "Semi final")
                {
                    priceOfTicket = 300.40;
                }
                else if (stageInTournament == "Final")
                {
                    priceOfTicket = 400;
                }
            }

            double priceForAllTickets = countOfTickets * priceOfTicket;
            bool freePhoto = false;

            if (priceForAllTickets > 4000) 
            {
                priceForAllTickets *= 0.75;
                freePhoto = true;
            }
            else if (priceForAllTickets > 2500)
            {
                priceForAllTickets *= 0.9;
            }
            if (photoWithTrophy == "Y" && !freePhoto)
            {
                priceForAllTickets += countOfTickets * 40;
            }

            Console.WriteLine($"{priceForAllTickets:F2}");
        }
    }
}
