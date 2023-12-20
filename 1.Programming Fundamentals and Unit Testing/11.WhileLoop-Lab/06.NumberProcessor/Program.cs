namespace _06.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Inc")
                {
                    number++;
                    command = Console.ReadLine();
                }
                else if (command == "Dec")
                {
                    number--;
                    command = Console.ReadLine();
                }
                else if (command == "End")
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}