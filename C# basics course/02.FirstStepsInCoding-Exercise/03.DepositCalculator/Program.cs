using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double sum = deposit + depositTerm * ((deposit * interestRate * 0.01 ) / 12);

            Console.WriteLine(sum);

        }
    }
}
