﻿using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n+1; i++)
        {
            Console.WriteLine(new string(' ',n-i)+new string('*',i)+" | "+ new string('*', i)+ new string(' ', n - i));
        }
    }
}