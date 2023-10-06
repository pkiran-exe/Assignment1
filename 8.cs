using System;

class tempProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amount of Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Kelvin
        double kelvin = celsius + 273.15;

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Kelvin = " + Math.Round(kelvin));
        Console.WriteLine("Fahrenheit = " + Math.Round(fahrenheit));
    }
}