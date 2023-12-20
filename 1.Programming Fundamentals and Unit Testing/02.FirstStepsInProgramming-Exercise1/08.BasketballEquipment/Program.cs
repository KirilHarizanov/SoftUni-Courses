namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double sneakers = trainingFee * 0.6;
            double team = sneakers * 0.8;
            double basketball = team * 0.25;
            double accessories = basketball * 0.20;

            double totallCosts = trainingFee + sneakers + team + basketball + accessories;

            Console.WriteLine(totallCosts);
        }
    }
}