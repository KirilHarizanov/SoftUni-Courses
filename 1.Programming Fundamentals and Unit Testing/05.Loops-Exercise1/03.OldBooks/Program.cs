namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToLookFor = Console.ReadLine();
            string inputBook = Console.ReadLine();
            int checkedBooksCount = 0;

            while (inputBook != "No More Books")
            {
                if (inputBook == bookToLookFor)
                {
                    break;
                }
                checkedBooksCount++;
                inputBook = Console.ReadLine();
            }

            if (inputBook == bookToLookFor)
            {
                Console.WriteLine($"You checked {checkedBooksCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }
        }
    }
}