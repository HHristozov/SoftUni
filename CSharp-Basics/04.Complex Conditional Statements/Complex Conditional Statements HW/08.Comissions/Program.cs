using System;
class Program
{
    static void Main()
    {
        string city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        double commision = 0;
        if (city == "sofia")
        {
            if (sales >= 0 && sales <= 500) commision = 0.05;
            if (sales > 500 && sales <= 1000) commision = 0.07;
            if (sales > 1000 && sales <= 10000) commision =0.08;
            if (sales > 10000) commision = 0.12;
        }
        if (city == "varna")
        {
            if (sales >= 0 && sales <= 500) commision = 0.045;
            if (sales > 500 && sales <= 1000) commision = 0.075;
            if (sales > 1000 && sales <= 10000) commision = 0.10;
            if (sales >= 10000) commision = 0.13;
        }
        if (city == "plovdiv")
        {
            if (sales >= 0 && sales <= 500) commision = 0.055;
            if (sales > 500 && sales <= 1000) commision = 0.08;
            if (sales > 1000 && sales <= 10000) commision = 0.12;
            if (sales > 10000) commision = 0.145;
        }
        if (sales>0&&(city=="sofia"||city=="varna"||city=="plovdiv"))
        {
            Console.WriteLine("{0:f2}",commision * sales);
        }
        else Console.WriteLine("error");



    }
}
