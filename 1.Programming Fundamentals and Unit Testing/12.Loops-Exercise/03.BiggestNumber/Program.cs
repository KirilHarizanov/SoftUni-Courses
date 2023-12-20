namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNumbers = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            for (int i = 1; i <= numOfNumbers; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber > maxNumber)
                {
                    maxNumber = curentNumber;                
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}