int n = int.Parse(Console.ReadLine());

for (int firstNum = 2; firstNum <= n; firstNum += 2)
{
    for (int secondNum = 1; secondNum <= n; secondNum += 2)
    {
        Console.Write($"{firstNum}{secondNum}{firstNum * secondNum} ");
    }
}