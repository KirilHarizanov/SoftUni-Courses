namespace _03.TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= row; col++)          
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}