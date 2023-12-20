using System;

namespace _04.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            int topStudents = 0;
            int between4And499 = 0;
            int between3And399 = 0;
            int failStudents = 0;
            double totalScore = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalScore += grade;

                if (grade >= 5.00)
                {
                    topStudents++;
                }
                else if (grade >= 4.00)
                {
                    between4And499++;
                }
                else if (grade >= 3.00)
                {
                    between3And399++;
                }
                else
                {
                    failStudents++;
                }
            }

            double topStudentsPercentage = (double)topStudents / studentCount * 100;
            double between4And499Percentage = (double)between4And499 / studentCount * 100;
            double between3And399Percentage = (double)between3And399 / studentCount * 100;
            double failPercentage = (double)failStudents / studentCount * 100;
            double averageScore = totalScore / studentCount;

            Console.WriteLine($"Top students: {topStudentsPercentage:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4And499Percentage:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3And399Percentage:F2}%");
            Console.WriteLine($"Fail: {failPercentage:F2}%");
            Console.WriteLine($"Average: {averageScore:F2}");
        }
    }
}
