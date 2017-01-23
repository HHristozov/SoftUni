using System;
class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int sum = 0;
        for (int index = 0; index < text.Length; index++)
        {
            char currentChar = text[index];
            if (currentChar == 'a') sum += 1;
            else if (currentChar == 'e') sum += 2;
            else if (currentChar == 'i') sum += 3;
            else if (currentChar == 'o') sum += 4;
            else if (currentChar == 'u') sum += 5;
        }
        Console.WriteLine(sum);
    }
}

