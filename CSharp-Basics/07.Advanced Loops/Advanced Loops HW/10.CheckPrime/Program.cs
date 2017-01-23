using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n<2)
        {
            Console.WriteLine("Not Prime");
        }
        else if (n==2 || n==3 || n==5 || n==7)
        {
            Console.WriteLine("Prime");
        }
        else if (n%2==0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0||n%9377==0||n%17==0)
        {
            Console.WriteLine("Not prime");
        }
        else Console.WriteLine("Prime");
        int counter = 1;
        while (counter <= Math.Sqrt(n))
        {
            if (n % counter == 0 && counter > 1)
            {
                Console.WriteLine("Not Prime");
            }
            counter++;
        }
    }
}