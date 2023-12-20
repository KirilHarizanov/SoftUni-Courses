int studentsCount = int.Parse(Console.ReadLine());

double grade = 0;

double sumGrades = 0;

double averageGrade = 0;

for (int i = 1; i <= studentsCount; i++)
{
    grade = double.Parse(Console.ReadLine());

    sumGrades += grade;
}

averageGrade = sumGrades / studentsCount;

Console.WriteLine($"{averageGrade:F2}");