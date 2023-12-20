using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = "";
            int maxGoals = 0;

            while (true)
            {
                string playerName = Console.ReadLine();
                if (playerName == "END")
                {
                    break;
                }

                int goalsScored = int.Parse(Console.ReadLine());

                if (goalsScored > maxGoals)
                {
                    bestPlayer = playerName;
                    maxGoals = goalsScored;
                }

                if (goalsScored >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            Console.WriteLine(maxGoals >= 3
                ? $"He has scored {maxGoals} goals and made a hat-trick !!!"
                : $"He has scored {maxGoals} goals.");
        }
    }
}
