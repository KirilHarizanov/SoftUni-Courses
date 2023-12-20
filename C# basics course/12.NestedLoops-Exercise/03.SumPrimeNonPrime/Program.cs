using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int compositeSum = 0;

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(currentNumber);
                    for (int i = 2; i <= sqrt; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        primeSum += currentNumber;
                    }
                    else
                    {
                        compositeSum += currentNumber;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compositeSum}");

        }
    }
}
