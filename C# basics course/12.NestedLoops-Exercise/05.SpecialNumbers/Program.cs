﻿using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int currentNumber = i;
                bool isSpecial = true;
                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;
                    if (lastDigit == 0 || n % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    currentNumber /= 10;
                }

                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
