using System;
namespace _05.MaxNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers>maxValue)
                {
                    maxValue = numbers;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
