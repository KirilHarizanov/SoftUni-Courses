namespace _08.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalCakePieces = width * length;

            string input = Console.ReadLine();
            while (input != "STOP")
            {
                int piecesToTake = int.Parse(input);
                totalCakePieces -= piecesToTake;
                if (totalCakePieces < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (totalCakePieces >= 0)
            {
                Console.WriteLine($"{totalCakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-1 * totalCakePieces} pieces more.");
            }
        }
    }
}