int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

MultiplicationSign(num1, num2, num3);

static void MultiplicationSign(int n1, int n2, int n3)
{
    int product = n1 * n2 * n3;

    if (product > 0)
    {
        Console.WriteLine("positive");
    }
    else if (product < 0)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("zero");
    }
}