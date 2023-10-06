using System;

class xyzProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int z = Convert.ToInt32(Console.ReadLine());

        int result1 = (x + y) * z;
        int result2 = (x * y) + (y * z);

        Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
    }
}