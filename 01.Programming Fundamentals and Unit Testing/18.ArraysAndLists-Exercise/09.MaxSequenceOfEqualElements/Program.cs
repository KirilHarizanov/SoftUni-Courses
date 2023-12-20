List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

int longestStart = 0;
int longestLength = 1;

int currentStart = 0;
int currentLength = 1;

for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] == numbers[i - 1])
    {
        currentLength++;
        if (currentLength > longestLength)
        {
            longestStart = currentStart;
            longestLength = currentLength;
        }
    }
    else
    {
        currentStart = i;
        currentLength = 1;
    }
}
for (int i = longestStart; i < longestStart + longestLength; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();