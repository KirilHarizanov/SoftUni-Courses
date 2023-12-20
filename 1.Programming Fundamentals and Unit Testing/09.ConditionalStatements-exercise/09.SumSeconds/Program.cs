namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int minutes = 0;
            int seconds = 0;

            int totalTime = time1 + time2 + time3;

            minutes = totalTime / 60;
            seconds = totalTime % 60;

            if (seconds < 10) 
            {
                string leadingZero = "0";

                Console.WriteLine($"{minutes}:{leadingZero}{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}