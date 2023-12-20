namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            double prevNum = 0;

            while (true)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (currentNum == stopNumber) 
                {
                    prevNum = prevNum * 1.2;

                    Console.WriteLine(prevNum);

                    break;
                }
                prevNum = currentNum;
            }           
        }
    }
}