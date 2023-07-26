using System;

class CalculateValues
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return 0;
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main()
    {
        CalculateValues calculator = new CalculateValues();

        
        Console.WriteLine("Enter 1 for Addition");
        Console.WriteLine("Enter 2 for Subtraction");
        Console.WriteLine("Enter 3 for Multiplication");
        Console.WriteLine("Enter 4 for Division");
        Console.WriteLine("Enter your choice (1/2/3/4): ");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        int ans = 0;

        switch (choice)
        {
            case 1:
                ans = calculator.Add(num1, num2);
                break;
            case 2:
                ans = calculator.Subtract(num1, num2);
                break;
            case 3:
                ans = calculator.Multiply(num1, num2);
                break;
            case 4:
                ans = calculator.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Your Answer is : " + ans);
    }
}
