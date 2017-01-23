using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double remainingWeekends = 48 - h;
            double gamesInHolidays = p * (2.0 / 3);
            double weekendsInSofia = remainingWeekends * (3.0 / 4);
            double result = gamesInHolidays + weekendsInSofia + h;
            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(result));

            }
            if (year == "leap")
            {
                Console.WriteLine(Math.Truncate(result * 0.15 + result));
            }
        }
    }
}
