using System;
using System.ComponentModel.Design;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowerType == "Roses") { price = 5; }
            else if (flowerType == "Dahlias") { price = 3.8; }
            else if (flowerType == "Tulips") { price = 2.8; }
            else if (flowerType == "Narcissus") { price = 3; }
            else if (flowerType == "Gladiolus") { price = 2.5; }

            double totalCosts = price * flowersCount;

            if (flowerType == "Roses" && flowersCount > 80)
            {
                totalCosts = totalCosts - 0.1 * totalCosts;
            }
            else if (flowerType == "Dahlias" && flowersCount > 90)
            {
                totalCosts = totalCosts - 0.15 * totalCosts;
            }
            else if (flowerType == "Tulips" && flowersCount > 80)
            {
                totalCosts = totalCosts - 0.15 * totalCosts;
            }
            else if (flowerType == "Narcissus" && flowersCount < 120)
            {
                totalCosts = totalCosts + 0.15 * totalCosts;
            }
            else if (flowerType == "Gladiolus" && flowersCount < 80)
            {
                totalCosts = totalCosts + 0.20 * totalCosts;
            }

            if (budget >= totalCosts) 
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {budget - totalCosts:F2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {totalCosts - budget:F2} leva more.");
            }
        }
    }
}
