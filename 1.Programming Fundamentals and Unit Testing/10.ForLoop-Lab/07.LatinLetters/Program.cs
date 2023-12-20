namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firsLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());

            for (char i = firsLetter; i <= lastLetter; i++) 
            {
                Console.Write(i + " ");
            }
        }
    }
}