using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var beginingStars = 1;
        if (n%2==0)
        {
            beginingStars = 2;
        }
        var leftRightBlanks = (n - beginingStars) / 2;

        for (int top = 1; top <= (n+1)/2; top++)
        {
            Console.Write(new string('-', leftRightBlanks));
            Console.Write(new string('*', beginingStars));
            Console.Write(new string('-', leftRightBlanks));
            leftRightBlanks--;
            beginingStars+=2;
            Console.WriteLine();
        }
        for (int bottom = 1; bottom <= n/2; bottom++)
        {
            Console.Write("|{0}|", new string('*',n-2));
            Console.WriteLine();
        }
    }
}