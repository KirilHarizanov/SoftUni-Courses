using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double clothingPricePerStatist = double.Parse(Console.ReadLine());

            double decorCosts = 0.1 * budget;
            double clothingCosts = statistsCount * clothingPricePerStatist;

            if (statistsCount > 150) 
            {
                clothingCosts = clothingCosts - 0.1 * clothingCosts;
            }

            double totalCosts = decorCosts + clothingCosts;

            if (budget >= totalCosts)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:F2} leva left.");
            }
            else 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:F2} leva more.");
            }
        }
    }
}
