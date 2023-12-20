using System;

namespace _02.FootballKit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double neededSum = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double sneakersPrice = (tshirtPrice + shortsPrice) * 2;

            double totalSum = tshirtPrice + shortsPrice + socksPrice + sneakersPrice;
            totalSum -= totalSum * 0.15; // Apply the discount

            if (totalSum >= neededSum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSum:F2} lv.");
            }
            else
            {
                double moneyNeeded = neededSum - totalSum;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {moneyNeeded:F2} lv. more.");
            }
        }
    }
}
