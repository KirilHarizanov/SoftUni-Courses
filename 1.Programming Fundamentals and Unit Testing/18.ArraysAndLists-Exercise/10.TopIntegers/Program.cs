List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

List<int> topIntegers = FindTopIntegers(numbers);

Console.WriteLine(string.Join(" ", topIntegers));


static List<int> FindTopIntegers(List<int> numbers)
{
    List<int> topIntegers = new List<int>();

    for (int i = 0; i < numbers.Count; i++)
    {
        bool isTopInteger = true;

        for (int j = i + 1; j < numbers.Count; j++)
        {
            if (numbers[i] <= numbers[j])
            {
                isTopInteger = false;
                break;
            }
        }

        if (isTopInteger)
        {
            topIntegers.Add(numbers[i]);
        }
    }

    return topIntegers;
}