namespace _9.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;

                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")             
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB;

                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}