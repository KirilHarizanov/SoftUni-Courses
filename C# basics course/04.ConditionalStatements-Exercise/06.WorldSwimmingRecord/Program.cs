using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distansInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSecond = double.Parse(Console.ReadLine());

            double totalTime = distansInMeters * timePerMeterInSecond + Math.Floor(distansInMeters / 15) * 12.5;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
