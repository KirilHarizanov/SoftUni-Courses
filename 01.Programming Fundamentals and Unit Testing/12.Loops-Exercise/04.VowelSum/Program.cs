namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= charCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                switch (currentChar)
                {
                    case 'a':
                        sum = sum + 1;
                        break;
                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}