using System;


class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade>=5.50&&grade<=6.00)
        {
            Console.WriteLine("Excellent!");
        }
      //  if (grade<5.50)
       // {
       //     Console.WriteLine("Not excellent.");
       // }
    }
}

