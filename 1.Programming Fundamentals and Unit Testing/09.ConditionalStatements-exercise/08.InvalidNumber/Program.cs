namespace _08.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isValid = true;

            if (num == 0 || (num >= 100 && num <= 200))
            {
                isValid = true;
            }
            else
            {
                isValid &= false;

                Console.WriteLine("invalid");
            }
        }
    }
}