namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            for (int i = days; days >= 1; days--)
            {
                int currentDay = days;

                Console.WriteLine($"{currentDay} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}