using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;

            int totalSteps = 0;

            string input = Console.ReadLine();

            while (input != "Going home")
            {
                int currentSteps = int.Parse(input);
                totalSteps += currentSteps;
                if (totalSteps >= goal) 
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (totalSteps < goal) 
            {
                int lastSteps = int.Parse(Console.ReadLine());
                totalSteps += lastSteps;
            }

            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
