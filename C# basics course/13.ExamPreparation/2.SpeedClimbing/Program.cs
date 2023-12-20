using System;

namespace _2.SpeedClimbing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanseInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double timeForClimb = distanseInMeters * timeInSecondsForOneMeter;
            double delay = Math.Floor(distanseInMeters / 50) * 30;

            double finalNeededTime = timeForClimb + delay;

            if (finalNeededTime < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {finalNeededTime:F2} seconds.");
            }
            else
            {
                double neededTime = finalNeededTime - recordInSeconds;
                Console.WriteLine($"No! He was {neededTime:F2} seconds slower.");
            }
        }
    }
}
