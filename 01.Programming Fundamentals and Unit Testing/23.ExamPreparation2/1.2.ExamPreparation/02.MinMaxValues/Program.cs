int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int minNum  = int.MaxValue;

// 3 42 61 7, 8 9 10 23

for (int index = 0; index < n; index++)
{
    if (numbers[index] > maxNum)
    {
        maxNum = numbers[index];
    }
}

Console.WriteLine(maxNum);

for (int index = 0; index < n; index++)
{
    if (numbers[index] < minNum)
    {
        minNum = numbers[index];
    }
}

Console.WriteLine(minNum);