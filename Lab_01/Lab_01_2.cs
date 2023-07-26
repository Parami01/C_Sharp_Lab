using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateAreaOfCircle(radius);

        Console.WriteLine($"Area of the circle with radius {radius} is: {area}");
    }

    static double CalculateAreaOfCircle(double radius)
    {
        return Math.PI * radius * radius;
    }
}
