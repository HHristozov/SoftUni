using System;

namespace _11.USDToBGN
{
    class Program
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Math.Round(bgn,2);
            Console.WriteLine(bgn);
        }
    }
}
