using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoesPrice = tax - 0.4 * tax;
            double kitPrice = shoesPrice - 0.2 * shoesPrice;
            double ballPrice = (1 / 4.0) * kitPrice;
            double accessoriesPrice = (1 / 5.0) * ballPrice;
            double totalPrice = tax + shoesPrice + kitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
