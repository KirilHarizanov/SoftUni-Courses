namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            double price = 0;
            double totalSum = 0;
            int nights = daysToStay - 1;

            if (typeRoom == "room for one person")
            {
                price = nights * 118;
            }
            else if (typeRoom == "apartment")
            {
                if (daysToStay < 10)
                {
                    price = (nights * 155) * 0.7;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = (nights * 155) * 0.65;
                }
                else if (daysToStay > 15)
                {
                    price = (nights * 155) * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                if (daysToStay < 10)
                {
                    price = (nights * 235) * 0.9;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = (nights * 235) * 0.85;
                }
                else if (daysToStay > 15)
                {
                    price = (nights * 235) * 0.8;
                }
            }

            if (assessment == "positive")
            {
                totalSum = price * 1.25;
            }
            else if (assessment == "negative")
            {
                totalSum = price * 0.90;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}