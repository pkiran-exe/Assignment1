using System;

class minmaxProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);

        Console.WriteLine("Maximum number: " + max);
        Console.WriteLine("Minimum number: " + min);
    }
}