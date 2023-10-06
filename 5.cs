using System;

class display4timesProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a digit: ");
        int input = Convert.ToInt32(Console.ReadLine());

        // Output using Console.Write
        Console.Write("{0} {0} {0} {0}\n", input);
        Console.Write("{0}{0}{0}{0}\n", input);

        // Output using {0} formatting
        Console.WriteLine("{0} {0} {0} {0}", input);
        Console.WriteLine("{0}{0}{0}{0}", input);
    }
}