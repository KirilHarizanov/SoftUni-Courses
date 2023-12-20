static int MathPower(int baseNum, int powerNum)
{
    int output = 1;

    for (int i = 1; i <= powerNum; i++)
    {
        output *= baseNum;
    }

    return output;
}

int baseNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int result = MathPower(baseNum, powerNum);

Console.WriteLine(result);