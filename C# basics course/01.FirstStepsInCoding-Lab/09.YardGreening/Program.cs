using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double totalCost = squareMeters * pricePerSquareMeter;
            double discount = totalCost * 0.18;
            double finalPrice = totalCost - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
