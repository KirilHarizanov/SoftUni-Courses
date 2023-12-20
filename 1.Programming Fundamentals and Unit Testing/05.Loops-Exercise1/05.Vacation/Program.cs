namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requeredMoneu = double.Parse(Console.ReadLine());
            double currentMoneu = double.Parse(Console.ReadLine());

            int days = 0;
            int consecutiveSpendDays = 0;

            while (currentMoneu < requeredMoneu && consecutiveSpendDays < 5)
            {
                string operation = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (operation == "save")
                {
                    currentMoneu += amount;
                    consecutiveSpendDays = 0;
                }
                else if (operation == "spend")
                {
                    if (amount > currentMoneu)
                    {
                        currentMoneu = 0;
                    }
                    else
                    {
                        currentMoneu -= amount;
                    }

                    consecutiveSpendDays++;
                }

                days++;
            }
            if (currentMoneu >= requeredMoneu)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}