using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int badGrades = 0;
            int grade = 1;
            double sumGrades = 0;

            while (grade <= 12)
            {
                double yearGrade = double.Parse(Console.ReadLine());

                if (yearGrade < 4) 
                {
                    badGrades++;
                    if (badGrades < 2)
                    {
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }

                grade++;
                sumGrades += yearGrade;
            }

            if (grade >= 12)
            {
                double averageGrade = sumGrades / 12;

                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
            
        }
    }
}
