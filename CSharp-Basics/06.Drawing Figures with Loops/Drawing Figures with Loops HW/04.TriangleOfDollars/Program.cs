using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int index = 1; index <= i; index++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}