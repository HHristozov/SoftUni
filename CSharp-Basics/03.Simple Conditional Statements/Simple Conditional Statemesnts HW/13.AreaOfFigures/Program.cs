using System;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side*side);
            }
            if (figure=="rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1*side2);
            }
            if (figure=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI*r*r);
            }
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine((h*side)/2);
            }

        }
    }
}
