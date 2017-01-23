using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                else if (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
