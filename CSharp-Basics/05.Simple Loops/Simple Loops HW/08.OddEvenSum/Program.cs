﻿using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            if (i%2==0)
            {
                sumEven += numbers;
            }
            else if (i%2!=0)
            {
                sumOdd += numbers;
            }         
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + sumOdd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = " + Math.Abs(sumOdd - sumEven));
        }
    }
}