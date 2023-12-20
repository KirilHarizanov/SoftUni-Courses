using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.5;
            double paintPrice = (paint + 0.1 * paint) * 14.5;
            double deluentPrice = diluent * 5;
            double totalMaterialPrice = nylonPrice + paintPrice + deluentPrice + 0.4;

            double workerPricePerHour = 0.3 * totalMaterialPrice;
            double totalWorkerPrice = workerPricePerHour * hours;

            Console.WriteLine(totalMaterialPrice + totalWorkerPrice);
        }
    }
}
