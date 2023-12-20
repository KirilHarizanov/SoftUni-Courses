using System;
using System.Dynamic;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n && salary > 0; i++)
            {
                string webside = Console.ReadLine();

                if (webside == "Facebook")
                {
                    salary -= 150;
                }
                else if (webside == "Instagram")
                {
                    salary -= 100;
                }
                else if (webside == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else 
            { 
                Console.WriteLine(salary); 
            }
        }
    }
}
