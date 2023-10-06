using System;

class triplesumProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        if (num1 == num2)
        {
            int tripleSum = sum * 3;
            Console.WriteLine("The triple of the sum is: " + tripleSum);
        }
        else
        {
            Console.WriteLine("The sum of the integers is: " + sum);
        }
    }
}