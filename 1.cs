using System;

namespace NumberSwapProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Input the First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            SwapNumbers(ref firstNumber, ref secondNumber);

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);
        }

        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}