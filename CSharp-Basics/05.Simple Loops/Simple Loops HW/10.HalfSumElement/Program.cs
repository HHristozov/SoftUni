using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > max) max = number;
            sum += number;
        }
        sum -= max;
        if (sum == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sum);
        }
        else
        {
            int diff = Math.Abs(max - sum);
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", diff);
        }
    }
}