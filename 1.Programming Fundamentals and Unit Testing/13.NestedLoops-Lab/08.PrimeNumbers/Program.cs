namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int curentNum = start; curentNum <= end; curentNum++)
            {
                bool isPrime = true;
                int divider = 2;               

                while (divider < end)
                {
                    if (curentNum == divider)
                    {
                        divider++;
                        continue;
                    }
                    if (curentNum % divider == 0) 
                    {
                        isPrime = false;
                        break;
                    }

                    divider++;
                }
                if (isPrime)
                {
                    Console.Write(curentNum + " ");
                }
            }
        }
    }
}