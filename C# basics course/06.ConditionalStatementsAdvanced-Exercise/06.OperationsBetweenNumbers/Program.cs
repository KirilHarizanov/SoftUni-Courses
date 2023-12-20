using System;

namespace _06.OperationsBetweenNumbers
{
class Program
  {
    static void Main()
    {
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());

        double result = 0;
        string output = "";

        switch (operation)
        {
            case '+':
                result = N1 + N2;
                output = $"{N1} + {N2} = {result}";
                if (result % 2 == 0)
                {
                    output = $"{N1} + {N2} = {result} - even";
                }
                else
                {
                    output = $"{N1} + {N2} = {result} - odd";
                }
                break;

            case '-':
                result = N1 - N2;
                output = $"{N1} - {N2} = {result}";
                if (result % 2 == 0)
                {
                    output = $"{N1} - {N2} = {result} - even";
                }
                else
                {
                    output = $"{N1} - {N2} = {result} - odd";
                }
                break;

            case '*':
                result = N1 * N2;
                output = $"{N1} * {N2} = {result}";
                if (result % 2 == 0)
                {
                    output = $"{N1} * {N2} = {result} - even";
                }
                else
                {
                    output = $"{N1} * {N2} = {result} - odd";
                }
                break;

            case '/':
                if (N2 == 0)
                {
                    output = $"Cannot divide {N1} by zero";
                }
                else
                {
                    result = (double)N1 / N2;
                    output = $"{N1} / {N2} = {result:F2}";
                }
                break;

            case '%':
                if (N2 == 0)
                {
                    output = $"Cannot divide {N1} by zero";
                }
                else
                {
                    result = N1 % N2;
                    output = $"{N1} % {N2} = {result}";
                }
                break;

            default:
                output = "Invalid operator";
                break;
        }

        Console.WriteLine(output);
    }
  }
}