namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nights;
                apartmentPrice = 65 * nights;

                if (nights > 7 && nights <= 14)
                    studioPrice -= studioPrice * 0.05;
                else if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * nights;
                apartmentPrice = 68.70 * nights;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;

                if (nights > 14)
                    apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}