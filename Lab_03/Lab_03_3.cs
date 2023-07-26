using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = FindSumOfDigits(number);

        Console.WriteLine($"Sum of the digits of the number: {sumOfDigits}");
    }

    static int FindSumOfDigits(int number)
    {
        int sum = 0;

        // Loop through each digit of the number
        for (int temp = number; temp != 0; temp /= 10)
        {
            int digit = temp % 10;
            sum += digit;
        }

        return sum;
    }
}
