using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double bankAccount = 0;

            while (input != "NoMoreMoney")
            {
                double currentAmount = double.Parse(input);

                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAccount += currentAmount;

                Console.WriteLine($"Increase: {currentAmount:F2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {bankAccount:F2}");
        }
    }
}
