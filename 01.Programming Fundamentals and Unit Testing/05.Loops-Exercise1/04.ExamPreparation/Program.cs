using System.Xml.Linq;

namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();

            int poorGradesCounter = 0;
            int solvedProblemsCounter = 0;
            double gradesSum = 0;
            string lastProblem = "";

            while (problemName != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4.00)
                {
                    poorGradesCounter++;
                }
                if (poorGradesCounter >= numberOfPoorGrades)
                {
                    Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");

                    break;
                }
       
                solvedProblemsCounter++;
                gradesSum += grade;
                lastProblem = problemName;

                problemName = Console.ReadLine();
            }
            if (problemName == "Enough")
            {
                double averageScore = gradesSum / solvedProblemsCounter;

                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}