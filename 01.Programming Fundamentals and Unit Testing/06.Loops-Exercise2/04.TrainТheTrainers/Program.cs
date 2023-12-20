namespace _04.TrainТheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juriMembers = int.Parse(Console.ReadLine());

            double totalGradesSum = 0;
            int presentationCount = 0;
            while (true)
            {
                String presName = Console.ReadLine();

                if (presName == "Finish")
                    break;

                presentationCount++;

                double presentationAverage = 0;

                for (int juryMember = 1; juryMember <= juriMembers; juryMember++)
                {
                    double curGrade = double.Parse(Console.ReadLine());

                    presentationAverage += curGrade;
                    totalGradesSum += curGrade;
                }

                Console.WriteLine($"{presName} - {presentationAverage / juriMembers:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {totalGradesSum / (presentationCount * juriMembers):f2}.");
        }
    }
}