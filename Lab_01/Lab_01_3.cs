using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
    }
}
