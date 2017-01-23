using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n<2)
        {
            Console.WriteLine("1");
        }
        int a = 1;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        Console.WriteLine(a);
    }
}
