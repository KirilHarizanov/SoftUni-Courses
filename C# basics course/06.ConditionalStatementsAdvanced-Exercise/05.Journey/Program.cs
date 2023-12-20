using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination;
            string holidayType = "";
            double expenses = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    expenses = 0.3 * budget;
                }
                else if (season == "winter") 
                {
                    holidayType = "Hotel";
                    expenses = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    expenses = 0.4 * budget;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    expenses = 0.8 * budget;
                }
            }
            else
            {
                destination = "Europe";
                holidayType = "Hotel";
                expenses = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {expenses:F2}");
        }
    }
}
