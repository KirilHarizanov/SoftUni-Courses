namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int neededDays = int.Parse(Console.ReadLine());

            int timeToReadTheBook = numOfPages / pagesPerHour;

            int hoursPerDay = timeToReadTheBook / neededDays;

            Console.WriteLine(hoursPerDay);
        }
    }
}