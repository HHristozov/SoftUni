using System;

namespace _06.MinValue
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers<minValue)
                {
                    minValue = numbers;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
