using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            int diff = examTime - arrivalTime;

            string verdict = "";
            if (diff < 0)
            {
                verdict = "Late";
            }
            else if (diff <= 30)
            {
                verdict = "On time";
            }
            else
            {
                verdict = "Early";
            }

            string formattedTime = "";
            int absoluteDiff = Math.Abs(diff);

            if (absoluteDiff < 60)
            {
                formattedTime = $"{absoluteDiff} minutes";
            }
            else
            {
                int diffHours = absoluteDiff / 60;
                int diffMinutes = absoluteDiff % 60;

                if (diffMinutes < 10)
                {
                    formattedTime = $"{diffHours}:0{diffMinutes} hours";
                }
                else
                {
                    formattedTime = $"{diffHours}:{diffMinutes} hours";
                }
            }
            string keyword = "";
            if (diff < 0)
            {
                keyword = "after";
            }
            else
            {
                keyword = "before";
            }

            Console.WriteLine(verdict);

            if (diff != 0)
            {
                Console.WriteLine($"{formattedTime} {keyword} the start");
            }
        }
    }
}
