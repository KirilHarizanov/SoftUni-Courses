namespace _6.BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double waterTemp = double.Parse(Console.ReadLine());

            if (waterTemp > 100) 
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}