namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                result = num1 / num2;
            }
            Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
        }
    }
}