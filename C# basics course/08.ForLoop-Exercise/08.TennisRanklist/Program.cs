using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());

            int newSeasonPoints = 0;
            int wonTournaments = 0;

            for (int i = 0; i < tournamentsCount; i++) 
            { 
                string position = Console.ReadLine();
                if (position == "W")
                {
                    newSeasonPoints += 2000;
                    wonTournaments++;
                }
                else if (position == "F") 
                {
                    newSeasonPoints += 1200;
                }
                else if (position == "SF")
                {
                    newSeasonPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {initialPoints + newSeasonPoints}");
            Console.WriteLine($"Average points: {newSeasonPoints / tournamentsCount}");
            Console.WriteLine($"{100.0 * wonTournaments / tournamentsCount:F2}%");
        }
    }
}
