using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double pricePerNight = 0;
            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18.00;
                    break;
                case "apartment":
                    pricePerNight = 25.00;
                    break;
                case "president apartment":
                    pricePerNight = 35.00;
                    break;
            }

            double totalPrice = pricePerNight * (days - 1); // days - 1 because the last night is free
            double discount = 0;

            if (days > 15)
            {
                if (roomType == "apartment")
                    discount = totalPrice * 0.5;
                else if (roomType == "president apartment")
                    discount = totalPrice * 0.2;
            }
            else if (days >= 10)
            {
                if (roomType == "apartment")
                    discount = totalPrice * 0.35;
                else if (roomType == "president apartment")
                    discount = totalPrice * 0.15;
            }
            else if (roomType == "apartment")
            {
                discount = totalPrice * 0.3;
            }
            else if (roomType == "president apartment")
            {
                discount = totalPrice * 0.1;
            }

            totalPrice -= discount;

            if (rating == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (rating == "negative")
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
