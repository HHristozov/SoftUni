using System;
class Program
{
    static void Main()
    {
        string typeOfProjection = Console.ReadLine().ToLower();
        double colums = double.Parse(Console.ReadLine());
        double rows = double.Parse(Console.ReadLine());
        double result = 0;
        if (typeOfProjection == "premiere")
        {
            result = rows * colums * 12.00;
        }
        if (typeOfProjection == "normal")
        {
            result = rows * colums * 7.50;
        }
        if (typeOfProjection == "discount")
        {
            result = rows * colums * 5.00;
        }
        Console.WriteLine("{0:f2} leva",result); 
    }
}

