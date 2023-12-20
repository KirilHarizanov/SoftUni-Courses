using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegeMenu = int.Parse(Console.ReadLine());

            double orderPrice = chikenMenu * 10.35 + fishMenu * 12.4 + vegeMenu * 8.15;

            double desertPrice = orderPrice * 0.2;

            double totalPrice = desertPrice + orderPrice + 2.5;

            Console.WriteLine(totalPrice);
        }
    }
}
