using System;
class Program
{
    static void Main()
    {
        int n = 10;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('*',n));
        }
    }
}