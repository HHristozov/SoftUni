using System;
class Program
{
    static void Main(string[] args)
    {      
        int n = 0;
        do
        {
            Console.Write("Enter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
            if (!(n < 1 || n > 100)) break;
            Console.WriteLine("Invalid number!");
        } while (true);
        Console.WriteLine("The number is: {0}", n);
    }
}