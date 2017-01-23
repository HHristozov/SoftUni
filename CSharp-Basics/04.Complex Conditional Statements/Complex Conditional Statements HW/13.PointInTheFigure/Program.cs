using System;

class Program
{
    static void Main()
    {
        double h = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        var firstRectangle = (x > h && x < 2 * h && y >= h && y < 4 * h);
        var secondRectangle = (x > 0 && x < 3 * h && y > 0 && y < h);
        if (firstRectangle || secondRectangle)
        {
            Console.WriteLine("inside");
        }
        else if (!(x >= h && x <= 2 * h && y >= h && y <= 4 * h) && !(x >= 0 && x <= 3 * h && y >= 0 && y <= h))
        {
            Console.WriteLine("outside");
        }
        else Console.WriteLine("border");
    }
}
