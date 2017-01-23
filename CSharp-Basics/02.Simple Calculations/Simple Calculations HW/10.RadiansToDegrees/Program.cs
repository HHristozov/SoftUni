using System;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double degrees = (rad * 180) / Math.PI;
            Math.Round(degrees, 0);
            Console.WriteLine(degrees);

        }
    }
}
