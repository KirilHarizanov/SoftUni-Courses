using System;
using System.ComponentModel;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double totalSum = 0;
            int presentationsCount = 0;
            string presentationName = Console.ReadLine();
            while (presentationName != "Finish")
            {
                double currentSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentSum += grade;
                }

                double currentAverage = currentSum / n;
                Console.WriteLine($"{presentationName} - {currentAverage:F2}.");

                totalSum += currentSum;
                presentationsCount++;
                presentationName = Console.ReadLine();
            }

            double finalAssessment = totalSum / (n * presentationsCount);

            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}
