using System;
class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine().ToLower();
        if (age<16)
        {
            if (gender == "m") Console.WriteLine("Master");
            if (gender == "f") Console.WriteLine("Miss");
        }
        if (age>=16)
        {
            if (gender == "m") Console.WriteLine("Mr.");
            if (gender == "f") Console.WriteLine("Ms.");
        }
    }
}