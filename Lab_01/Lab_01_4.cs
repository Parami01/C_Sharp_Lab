using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the salary of the employee: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the tax rate (in percentage): ");
        double taxRate = double.Parse(Console.ReadLine());

        double taxAmount = salary * (taxRate / 100);
        double salaryAfterTax = salary - taxAmount;

        Console.WriteLine($"Salary after tax: {salaryAfterTax}");
    }
}
