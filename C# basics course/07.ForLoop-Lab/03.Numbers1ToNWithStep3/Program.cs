using System;
using System.Dynamic;

namespace _03.Numbers1ToNWithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
