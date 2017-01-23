using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b!=0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        Console.WriteLine(a);
    }
}