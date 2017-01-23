using System;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Math.Round(fahrenheit, 2);
            Console.WriteLine(fahrenheit);
        }
    }
}
