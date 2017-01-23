using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++, number++)
            {
                Console.Write("{0} ", number);
                if (number == n)
                {
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine();
        }
    }
}