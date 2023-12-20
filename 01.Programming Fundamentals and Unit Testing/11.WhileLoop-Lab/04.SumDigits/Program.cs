namespace _04.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int lastNum = num % 10;

                sum = sum + lastNum;

                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}