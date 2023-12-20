using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (projectionType) 
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.5;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
            }

            double totalProfit = rows * cols * ticketPrice;

            Console.WriteLine($"{totalProfit:F2} leva");
        }
    }
}