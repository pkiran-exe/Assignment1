using System;

class absolutevalueProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double difference = Math.Abs(num1 - num2);

        if (num1 > num2)
        {
            double doubleDifference = 2 * difference;
            Console.WriteLine("Double the absolute difference: " + doubleDifference);
        }
        else
        {
            Console.WriteLine("Absolute difference: " + difference);
        }
    }
}