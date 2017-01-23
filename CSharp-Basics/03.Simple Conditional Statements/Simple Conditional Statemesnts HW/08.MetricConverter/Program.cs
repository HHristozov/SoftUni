using System;
using System.Collections.Generic;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string firstDistance = Console.ReadLine();
            string secondDistance = Console.ReadLine();

            var currencies = new Dictionary<string, double>()
            {
                {"mm", 1000 },
                {"centimeters", 100},
                {"miles", 0.000621371192},
                {"inches", 39.3700787},
                {"kilometers", 0.001},
                {"feet" , 3.2808399},
                {"m" , 1},
                {"yards", 1.0936133}
        };
            double result = number / currencies[firstDistance] * currencies[secondDistance];

            Console.WriteLine("{0} {1}", result, secondDistance);
        }
    }
}
