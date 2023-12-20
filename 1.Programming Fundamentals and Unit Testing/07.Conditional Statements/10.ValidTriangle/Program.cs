using System.Security.Principal;

namespace _10.ValidTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (c + b <= a) 
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (a + c <= b)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (a + b <= c)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else
            {
                Console.WriteLine("Valid Triangle");
            }
        }
    }
}