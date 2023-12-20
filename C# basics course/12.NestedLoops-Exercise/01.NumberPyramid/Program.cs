using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                bool shouldStop = false;
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;

                    if (currentNumber > n) 
                    {
                        shouldStop = true;
                        break;
                    }
                }

                if (shouldStop)
                {
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}
