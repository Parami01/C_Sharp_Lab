using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
