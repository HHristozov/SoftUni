using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double amount = double.Parse(Console.ReadLine());
        if (city=="sofia")
        {
            if (product == "coffee") Console.WriteLine(amount*0.50);
            if (product == "water") Console.WriteLine(amount*0.80);
            if (product == "beer") Console.WriteLine(amount*1.20);
            if (product == "sweets") Console.WriteLine(amount*1.45);
            if (product == "peanuts") Console.WriteLine(amount*1.60);
        }
        if (city == "plovdiv")
        {
            if (product == "coffee") Console.WriteLine(amount*0.40);
            if (product == "water") Console.WriteLine(amount*0.70);
            if (product == "beer") Console.WriteLine(amount*1.15);
            if (product == "sweets") Console.WriteLine(amount*1.30);
            if (product == "peanuts") Console.WriteLine(amount*1.50);
        }
        if (city == "varna")
        {
            if (product == "coffee") Console.WriteLine(amount*0.45);
            if (product == "water") Console.WriteLine(amount*0.70);
            if (product == "beer") Console.WriteLine(amount*1.10);
            if (product == "sweets") Console.WriteLine(amount*1.35);
            if (product == "peanuts") Console.WriteLine(amount*1.55);
        }
    }
}
