using System;

class Program
{
   static void Main()
   {
        string product = Console.ReadLine();
        if (product == "banana" || product == "apple" || product == "kiwi"
        || product == "cherry" || product == "lemon" || product == "grapes")
        {
            Console.WriteLine("fruit");
        }
        if (product == "tomato" || product == "cucumber" || product == "pepper"
        || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        if (!(product == "banana" || product == "apple" || product == "kiwi"
        || product == "cherry" || product == "lemon" || product == "grapes"|| product == "tomato" || product == "cucumber" || product == "pepper"
        || product == "carrot"))
        {
            Console.WriteLine("unknown");
        }
    }
}

