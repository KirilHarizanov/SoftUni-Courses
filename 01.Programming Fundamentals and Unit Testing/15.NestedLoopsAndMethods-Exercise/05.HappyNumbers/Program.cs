int n = int.Parse(Console.ReadLine());

for (int num1 = 1; num1 <= 9; num1++)
{
    for (int num2 = 0; num2 <= 9; num2++)
    {
        for (int num3 = 0; num3 <= 9; num3++)
        {
            for(int num4 = 0; num4 <= 9; num4++)
            {
                if (num1 + num2 == n && num3 + num4 == n)
                {
                    Console.Write($"{num1}{num2}{num3}{num4} ");
                }
            }
        }
    }
}