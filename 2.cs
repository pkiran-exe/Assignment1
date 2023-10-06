using System;

namespace MultiplyNumbersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;

            Console.Write("Input the first number to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            int result = MultiplyNumbers(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = {result}");
        }

        static int MultiplyNumbers(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}