int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int index = numbers.Length -1; index >= numbers.Length - n; index--)
{
    sum += numbers[index]; 
}

double averageValue = (double)sum / n;

Console.WriteLine($"{averageValue:F2}");