namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double resultInSantimeters = inches * 2.54;

            Console.WriteLine(resultInSantimeters);
        }
    }
}