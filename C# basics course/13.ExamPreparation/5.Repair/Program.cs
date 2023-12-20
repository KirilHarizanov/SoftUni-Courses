using System;

namespace _5.Repair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hightOfWall = int.Parse(Console.ReadLine());
            int widhtOfWall = int.Parse(Console.ReadLine());
            int areaForWindowsInPercent = int.Parse(Console.ReadLine());

            double areaForPainting = hightOfWall * widhtOfWall * 4;
            areaForPainting = Math.Floor(areaForPainting - (areaForPainting * areaForWindowsInPercent / 100));

            string input = Console.ReadLine();

            while (input != "Tired!")
            {
                int paintInLiters = int.Parse(input);

                areaForPainting -= paintInLiters;

                if (areaForPainting <= 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (areaForPainting > 0)
            {
                Console.WriteLine($"{areaForPainting} quadratic m left.");
            }
            else if (areaForPainting < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPainting)} l paint left!");
            }
            else
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
        }
    }
}
