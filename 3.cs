using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;
        double remainder = num1 % num2;

        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {difference}");
        Console.WriteLine($"{num1} x {num2} = {product}");
        Console.WriteLine($"{num1} / {num2} = {quotient}");
        Console.WriteLine($"{num1} mod {num2} = {remainder}");
    }
}