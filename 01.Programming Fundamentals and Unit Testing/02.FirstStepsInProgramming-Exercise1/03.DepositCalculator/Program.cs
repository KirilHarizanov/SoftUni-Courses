namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double totalAmount = depositAmount + months * (depositAmount * (interest / 100)) / 12;

            Console.WriteLine(totalAmount);
        }
    }
}