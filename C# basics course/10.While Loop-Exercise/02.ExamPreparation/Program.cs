using System;
using System.Dynamic;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());

            int sum = 0, problemsCount = 0, badGradesCount = 0;
            string lastProblemName = "";
            bool hasFailed = false;

            string inputProblem = Console.ReadLine();

            while (inputProblem != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());

                if (currentGrade <= 4)
                {
                    badGradesCount++;
                    if (badGradesCount == maxBadGrades) 
                    {
                        hasFailed = true;
                        break;
                    }
                }
                sum += currentGrade;
                problemsCount++;

                lastProblemName = inputProblem;
                inputProblem = Console.ReadLine();
            }
            if (hasFailed)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {1.0 * sum / problemsCount:F2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
        }
    }
}
