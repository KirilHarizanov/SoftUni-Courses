using System;

class Program
{
    static void Main()
    {
        string city = Console.ReadLine();
        double salesVolume = double.Parse(Console.ReadLine());

        double commission = 0;

        if (salesVolume < 0 || (city != "Sofia" && city != "Varna" && city != "Plovdiv"))
        {
            Console.WriteLine("error");
        }
        else
        {
            if (city == "Sofia")
            {
                if (salesVolume <= 500)
                    commission = salesVolume * 0.05;
                else if (salesVolume <= 1000)
                    commission = salesVolume * 0.07;
                else if (salesVolume <= 10000)
                    commission = salesVolume * 0.08;
                else
                    commission = salesVolume * 0.12;
            }
            else if (city == "Varna")
            {
                if (salesVolume <= 500)
                    commission = salesVolume * 0.045;
                else if (salesVolume <= 1000)
                    commission = salesVolume * 0.075;
                else if (salesVolume <= 10000)
                    commission = salesVolume * 0.1;
                else
                    commission = salesVolume * 0.13;
            }
            else if (city == "Plovdiv")
            {
                if (salesVolume <= 500)
                    commission = salesVolume * 0.055;
                else if (salesVolume <= 1000)
                    commission = salesVolume * 0.08;
                else if (salesVolume <= 10000)
                    commission = salesVolume * 0.12;
                else
                    commission = salesVolume * 0.145;
            }

            Console.WriteLine($"{commission:f2}");
        }
    }
}
