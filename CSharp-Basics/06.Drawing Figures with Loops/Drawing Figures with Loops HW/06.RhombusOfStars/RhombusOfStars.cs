using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ',n-i));
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = n-1; i > 0; i--)
        {
            Console.Write(new string(' ', n - i));
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}