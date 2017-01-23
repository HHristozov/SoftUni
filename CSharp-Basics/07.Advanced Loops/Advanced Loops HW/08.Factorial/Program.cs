using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sum = 1;
        do
        {
            sum = sum * n;
            n--;
        } while (n>0);
        Console.WriteLine(sum);
    }
}

