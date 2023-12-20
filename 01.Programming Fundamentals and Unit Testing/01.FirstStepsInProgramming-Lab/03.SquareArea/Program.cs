namespace _03.SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideOfASquare = double.Parse(Console.ReadLine());

            double area = sideOfASquare * sideOfASquare;

            Console.WriteLine(area);
        }
    }
}