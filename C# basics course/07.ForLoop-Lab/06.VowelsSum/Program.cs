﻿using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (currentLetter == 'a') 
                {
                    sum += 1;
                }
                else if (currentLetter == 'e')
                {
                    sum += 2;
                }
                else if (currentLetter == 'i')
                {
                    sum += 3;
                }
                else if (currentLetter == 'o')
                {
                    sum += 4;
                }
                else if (currentLetter == 'u')
                {
                    sum += 5;
                }
            }

                Console.WriteLine(sum);

        }
    }
}
