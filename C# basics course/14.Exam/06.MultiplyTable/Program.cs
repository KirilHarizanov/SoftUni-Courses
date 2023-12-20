using System;

namespace _06.MultiplyTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 111 || number > 999)
            {
                return;
            }

            int thirdDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int firstDigit = number / 100;

            if (firstDigit <= 0 || secondDigit <= 0 || thirdDigit <= 0)
            {
                return;
            }

            for (int i = 1; i <= thirdDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= firstDigit; k++)
                    {
                        int result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
