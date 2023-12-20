using System;

namespace _1.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double priceForStatues = rent - (rent * 0.3);
            double priceForCatering = priceForStatues * 0.85;
            double priceForSound = priceForCatering / 2;

            double finalPrice = rent + priceForStatues + priceForCatering + priceForSound;

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
