namespace _09.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeVolume = width * lenght * height;
            int takenVolume = 0;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                takenVolume += boxes;
                if (takenVolume > freeVolume)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (freeVolume >= takenVolume)
            {
                Console.WriteLine($"{freeVolume - takenVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {takenVolume - freeVolume} Cubic meters more.");
            }
        }
    }
}