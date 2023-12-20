int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int mrightMiddleElement = numbers[numbers.Length / 2];

int leftMiddleElement = numbers[numbers.Length / 2 -1];

double result = (leftMiddleElement + mrightMiddleElement) / 2.00;

Console.WriteLine($"{result:F2}");