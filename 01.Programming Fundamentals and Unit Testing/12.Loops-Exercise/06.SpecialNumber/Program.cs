namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int constNumber = number;

            bool isSpecial = true;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (constNumber % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }

                number = number / 10;
            }

            if (isSpecial == true)
            {
                Console.WriteLine($"{constNumber} is special");
            }
            else
            {
                Console.WriteLine($"{constNumber} is not special");
            }
        }
    }
}