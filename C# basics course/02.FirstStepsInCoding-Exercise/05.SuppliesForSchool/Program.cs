using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningSupplies = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double cleaningSuppliesPrice = cleaningSupplies * 1.20;

            double sum = pensPrice + markersPrice + cleaningSuppliesPrice;

            double priceWithDiscount = sum - (sum * discountPercent * 0.01);

            Console.WriteLine(priceWithDiscount);
        }
    }
}
