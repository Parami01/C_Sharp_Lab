using System;

class Program
{
    static void Main()
    {
        const int NumberOfInputs = 10;

        for (int i = 1; i <= NumberOfInputs; i++)
        {
            Console.Write($"Enter input {i}: ");
            int number = int.Parse(Console.ReadLine());

            if (IsEven(number))
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
