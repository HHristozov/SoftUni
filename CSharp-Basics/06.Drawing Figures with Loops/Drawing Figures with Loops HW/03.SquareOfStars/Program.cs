using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
            for (int index = 1; index < n; index++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();    
        }
    }
}