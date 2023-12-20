using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double catFoodPrice = 4.00;

            double dogFoodPriceSum = dogFood * dogFoodPrice;
            double catFoodPriceSum = catFood * catFoodPrice; 

            double sumPrice = dogFoodPriceSum + catFoodPriceSum;

            Console.WriteLine($"{sumPrice} lv.");
        }
    }
}
