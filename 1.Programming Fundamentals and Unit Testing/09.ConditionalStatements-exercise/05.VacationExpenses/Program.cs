namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                if (accType == "Hotel")
                {
                    price = days * 30 * 0.8;
                }
                else if (accType == "Camping") 
                {
                    price = days * 10 * 0.8;
                }
            }
            else if (season == "Summer") 
            {
                if (accType == "Hotel")
                {
                    price = days * 50;
                }
                else if (accType == "Camping")
                {
                    price = days * 30;
                }
            }
            else if (season == "Autumn")
            {
                if (accType == "Hotel")
                {
                    price = days * 20 * 0.7;
                }
                else if (accType == "Camping")
                {
                    price = days * 15 * 0.7;
                }
            }
            else if (season == "Winter")
            {
                if (accType == "Hotel")
                {
                    price = days * 40 * 0.9;
                }
                else if (accType == "Camping")
                {
                    price = days * 10 * 0.9;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}