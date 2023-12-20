namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;                                        

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine($"Balance: {balance:f2}");
                    break;
                }

                double curentMoneyIncome = double.Parse(command);

                if (curentMoneyIncome > 0)
                {
                    balance += curentMoneyIncome;
                    Console.WriteLine($"Increase: {curentMoneyIncome:f2}");
                }
                else
                {
                    balance += curentMoneyIncome;
                    Console.WriteLine($"Decrease: {Math.Abs(curentMoneyIncome):f2}");
                }
            }
        }
    }
}