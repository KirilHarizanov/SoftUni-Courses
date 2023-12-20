namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++) 
            {
                sum += i;

                if (i == 1) 
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write("+" + i);
                }          
            }
            Console.Write("=" + sum);
        }
    }
}