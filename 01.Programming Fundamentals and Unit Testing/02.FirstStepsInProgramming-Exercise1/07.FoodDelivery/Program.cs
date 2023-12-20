namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegeMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.40;
            double vegeMenusPrice = vegeMenus * 8.15;          

            double totalCosts = chickenMenusPrice + fishMenusPrice + vegeMenusPrice;

            double desertPrice = totalCosts * 0.2;

            double grandTotalCosts = totalCosts + desertPrice + 2.50;

            Console.WriteLine(grandTotalCosts);
        }
    }
}