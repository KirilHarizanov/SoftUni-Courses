using System;

namespace _01.Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            int numberOfTransportCards = int.Parse(Console.ReadLine());
            int numberOfMuseumTickets = int.Parse(Console.ReadLine());

            double totalNightsCost = numberOfNights * 20;
            double totalTransportCost = numberOfTransportCards * 1.60;
            double totalMuseumCost = numberOfMuseumTickets * 6;

            double totalExpenses = totalNightsCost + totalTransportCost + totalMuseumCost;
            double totalCostForWholeGroup = totalExpenses * numberOfPeople;
            double additionalExpenses = totalCostForWholeGroup * 0.25;
            double totalCost = totalCostForWholeGroup + additionalExpenses;

            Console.WriteLine($"{totalCost:F2}");
        }
    }
}
