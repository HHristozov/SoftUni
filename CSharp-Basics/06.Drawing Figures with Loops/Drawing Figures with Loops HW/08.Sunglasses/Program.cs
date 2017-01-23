using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = n;
        int width = 5 * n;
 
        for (int i = 0; i < n; i++)
        {
            if (i==0||i==n-1)
            {
                Console.Write("{0}{1}{0}",new string('*',2*n),
                    new string(' ',n));
            }
            else
            {
                Console.Write("*{0}*",new string('/',(n*2)-2));
                if (i==(n-1)/2)
                {
                    Console.Write(new string('|',n));
                }
                else
                {
                    Console.Write(new string(' ',n));
                }
                Console.Write("*{0}*", new string('/', (n * 2) - 2));
            }
            Console.WriteLine();
        }
    }
}