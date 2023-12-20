namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int totalTickets = rows * seats;
            double totalPrice = 0;

            if (typeOfMovie == "Premiere")
            {
                totalPrice = totalTickets * 12.00;
            }
            else if (typeOfMovie == "Normal")
            {
                totalPrice = totalTickets * 7.50;
            }
            else if (typeOfMovie == "Discount")
            {
                totalPrice = totalTickets * 5.00;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}