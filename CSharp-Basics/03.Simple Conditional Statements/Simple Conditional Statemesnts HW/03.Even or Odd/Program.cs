﻿using System;

namespace _03.Even_or_Odd
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("even");
            }
            else Console.WriteLine("odd");
        }
    }
}