using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int lastDigit = 0;
        do
        {
            lastDigit = n % 10;
            sum = sum + lastDigit;
            n = n / 10;
        } while (n>0);
        Console.WriteLine(sum);
    }
}