using System;

namespace _4.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int countOfJury = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfJury; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                double pointForActor = name.Length * points / 2;

                startingPoints += pointForActor;

                if (startingPoints > 1250.5)
                {
                    break;
                }
            }

            if (startingPoints > 1250.5) 
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {startingPoints:F1}!");
            }
            else
            {
                double neededPoints = 1250.5 - startingPoints;
                Console.WriteLine($"Sorry, {nameOfActor} you need {neededPoints:F1} more!");
            }
        }
    }
}
