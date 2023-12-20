namespace _05.DivisionToTwoThreeFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());

            double count2 = 0;
            double count3 = 0;
            double count4 = 0;

            double percentage2 = 0;
            double percentage3 = 0;
            double percentage4 = 0;

            for (int i = 1; i <= numOfNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0) 
                {
                    count2++;
                }
                if (currentNum % 3 == 0) 
                {
                    count3++;
                }
                if (currentNum % 4 == 0) 
                {
                    count4++;
                }
            }

            percentage2 = count2 / numOfNums * 100;

            Console.WriteLine($"{percentage2:f2}%");

            percentage3 = count3 / numOfNums * 100;

            Console.WriteLine($"{percentage3:f2}%");

            percentage4 = count4 / numOfNums * 100;

            Console.WriteLine($"{percentage4:f2}%");
        }
    }
}