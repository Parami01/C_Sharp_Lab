using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSumOfOddNumbers(n);

        Console.WriteLine($"Sum of all odd numbers from 1 to {n}: {sum}");
    }

    static int CalculateSumOfOddNumbers(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}
