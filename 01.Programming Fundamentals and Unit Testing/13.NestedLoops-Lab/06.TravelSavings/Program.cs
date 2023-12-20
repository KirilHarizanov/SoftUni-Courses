namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double neededBudget = int.Parse(Console.ReadLine());

                double collectedMoney = 0;

                while (true) 
                {
                    double currentMoney = double.Parse(Console.ReadLine());

                    collectedMoney += currentMoney;

                    Console.WriteLine($"Collected: {collectedMoney:f2}");

                    if (collectedMoney >= neededBudget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }

                destination = Console.ReadLine();
            }
        }
    }
}