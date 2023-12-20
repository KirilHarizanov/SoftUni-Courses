namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= numberOfNumbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}