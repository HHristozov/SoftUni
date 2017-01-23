using System;
class Program
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int rightSum = 0;
        int leftSum = 0;
        int sum = 0;
        for (int i = 0; i < n1; i++)
        {
            sum = int.Parse(Console.ReadLine());
            rightSum += sum;
        }
        for (int i = 0; i < n1; i++)
        {
            sum = int.Parse(Console.ReadLine());
            leftSum += sum;
        }
        if (rightSum == leftSum)
        {
            Console.WriteLine("Yes, sum ={0}", rightSum);
        }
        else Console.WriteLine("No, diff ={0} ", Math.Abs(leftSum - rightSum));

    }
}
