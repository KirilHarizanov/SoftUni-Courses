using System;

namespace _03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double pricePerKilometer = 0.0;

            if (weight < 1)
                pricePerKilometer = 0.03;
            else if (weight <= 10)
                pricePerKilometer = 0.05;
            else if (weight <= 40)
                pricePerKilometer = 0.10;
            else if (weight <= 90)
                pricePerKilometer = 0.15;
            else if (weight <= 150)
                pricePerKilometer = 0.20;

            double totalCost = pricePerKilometer * distance;

            if (serviceType == "express")
            {
                double percent = 0.0;

                if (weight < 1)
                    percent = 0.80;
                else if (weight <= 10)
                    percent = 0.40;
                else if (weight <= 40)
                    percent = 0.05;
                else if (weight <= 90)
                    percent = 0.02;
                else if (weight <= 150)
                    percent = 0.01;

                totalCost += (totalCost * percent) * distance;
            }


            Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalCost:F2} lv.");
        }
    }
}
