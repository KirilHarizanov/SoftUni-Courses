namespace _03.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            int bonusPoints = 0;
            int totalPoints = 0;

            if (points >= 0 && points <= 3)
            {
                bonusPoints += 5;
                totalPoints = bonusPoints + points;
            }
            else if (points >= 4 && points <= 6)
            {
                bonusPoints += 15;
                totalPoints = bonusPoints + points;
            }
            else if (points >= 7 && points <= 9)
            {
                bonusPoints += 20;
                totalPoints = bonusPoints + points;
            }

            Console.WriteLine(totalPoints);
        }
    }
}