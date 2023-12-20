namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesOfPens = int.Parse(Console.ReadLine());
            int packagesOfMarkers = int.Parse(Console.ReadLine());
            int litersOfBoardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double packagesOfPensPrice = packagesOfPens * 5.80;
            double packagesOfMarkersPrice = packagesOfMarkers * 7.20;
            double boardCleanerPrice = litersOfBoardCleaner * 1.20;

            double totalAmount = packagesOfPensPrice + packagesOfMarkersPrice + boardCleanerPrice;

            double totalDiscount = discount / 100.0;

            double grandTotalAmount = totalAmount - (totalAmount * totalDiscount);

            Console.WriteLine(grandTotalAmount);
        }
    }
}