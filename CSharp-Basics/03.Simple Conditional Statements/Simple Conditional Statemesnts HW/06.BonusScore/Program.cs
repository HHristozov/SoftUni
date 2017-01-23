using System;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonusScore = 0;
            if (number<=100)
            {
                bonusScore = 5;
            }
            if (number>100&&number<=1000)
            {
                bonusScore = (number *20/100);
            }
            if (number>1000)
            {
                bonusScore = (number * 10 / 100);
            }
            if (number%2==0)
            {
                bonusScore = bonusScore + 1;
            }
            if (number%10==5)
            {
                bonusScore = bonusScore + 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(number+bonusScore);
        }
    }
}
