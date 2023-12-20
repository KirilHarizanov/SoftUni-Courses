namespace _05.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num < 1 || num > 100)
                {
                    num = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(num);
                    break;
                }
            }
        }
    }
}