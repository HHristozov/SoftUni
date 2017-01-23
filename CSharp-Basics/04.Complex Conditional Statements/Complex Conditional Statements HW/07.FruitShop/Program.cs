using System;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double banana = 2.50;
            double apple = 1.20;
            double orange = 0.85;
            double grapefruit = 1.45;
            double kiwi = 2.70;
            double pineapple = 5.50;
            double grapes = 3.85;
            double result = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        result += (amount * banana);
                        break;
                    case "apple":
                        result += (amount * apple);
                        break;
                    case "orange":
                        result += (amount * orange);
                        break;
                    case "grapefruit":
                        result += (amount * grapefruit);
                        break;
                    case "kiwi":
                        result += (amount * kiwi);
                        break;
                    case "pineapple":
                        result += (amount * pineapple);
                        break;
                    case "grapes":
                        result += (amount * grapes);
                        break;

                    default:
                        break;
                }
            }
            else if (day == "Sunday" || day == "Saturday")
            {
                switch (fruit)
                {
                    case "banana":
                        result += (amount * (banana + 0.20));
                        break;
                    case "apple":
                        result += (amount * (apple + 0.05));
                        break;
                    case "orange":
                        result += (amount * (orange + 0.05));
                        break;
                    case "grapefruit":
                        result += (amount * (grapefruit + 0.15));
                        break;
                    case "kiwi":
                        result += (amount * (kiwi + 0.30));
                        break;
                    case "pineapple":
                        result += (amount * (pineapple + 0.10));
                        break;
                    case "grapes":
                        result += (amount * (grapes + 0.35));
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(result);
            Math.Round(result, 0);
            if (day != "Monday" || day != "Tuesday" || day != "Wedbesday" ||
day != "Thursday" || day != "Friday" || day != "Saturday" ||
day != "Sunday" || fruit != "banana" || fruit != "apple" ||
fruit != "orange" || fruit != "grapefruit" || fruit != "kiwi" ||
fruit != "pineapple" || fruit != "grapes")
            {
                Console.WriteLine("error");
            }

        }
    }
}
