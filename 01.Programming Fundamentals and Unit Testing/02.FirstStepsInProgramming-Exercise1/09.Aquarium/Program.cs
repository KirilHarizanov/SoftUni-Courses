namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double volume = length * width * height * 0.001;
            double waterPerc = (100 - perc) /100;           
            Console.WriteLine($"{volume * waterPerc:F2}");
        }
    }
}