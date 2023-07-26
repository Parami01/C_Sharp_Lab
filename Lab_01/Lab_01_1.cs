using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your batch: ");
        string batch = Console.ReadLine();

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Batch: {batch}");
    }
}
