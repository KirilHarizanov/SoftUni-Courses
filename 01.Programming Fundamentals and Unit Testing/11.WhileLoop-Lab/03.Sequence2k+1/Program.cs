namespace _03.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());

            int currentNum = 1;

            while (maxNum >= currentNum)
            {
                Console.WriteLine(currentNum);

                currentNum = currentNum * 2 + 1;
            }
        }
    }
}