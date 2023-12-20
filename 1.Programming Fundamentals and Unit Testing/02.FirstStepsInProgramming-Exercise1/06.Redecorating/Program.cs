namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int craftsmanHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint * 1.1) * 14.50;
            double thinnerPrice = thinner * 5.00;

            double totalCosts = nylonPrice + paintPrice + thinnerPrice + 0.40;

            double craftsmanCosts = totalCosts * 0.3;

            double grandTotalCosts = totalCosts + craftsmanCosts * craftsmanHours;

            Console.WriteLine(grandTotalCosts);
        }
    }
}