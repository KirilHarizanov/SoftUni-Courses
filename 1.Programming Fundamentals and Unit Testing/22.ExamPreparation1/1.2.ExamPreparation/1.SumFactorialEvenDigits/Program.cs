int number = int.Parse(Console.ReadLine());

int totalResult = 0;

while (number != 0)
{
    int digit = number % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorial(digit);

        totalResult += resultFactorial;
    }

    number = number / 10;
}
Console.WriteLine(totalResult);

static int CalculateFactorial(int number)
{
    int result = 1;

    while (number > 0)
    {
        result *= number;
        number--;
    }

    return result;
}