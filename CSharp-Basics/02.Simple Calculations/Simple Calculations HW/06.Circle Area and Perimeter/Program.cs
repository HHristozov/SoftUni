using System;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("The area of the circle is: {0}",area);
            Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
        }
    }
}
