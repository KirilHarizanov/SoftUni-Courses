using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int currentNumber = i;
                int evenSum = 0;
                int oddSum = 0;
                bool isEven = true;

                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;

                    if (isEven)
                    {
                        evenSum += lastDigit;
                    }
                    else
                    {
                        oddSum += lastDigit;
                    }

                    isEven = !isEven;

                    currentNumber /= 10;
                }
                
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
