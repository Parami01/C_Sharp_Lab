using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateAreaOfCircle(radius);
        double circumference = CalculateCircumferenceOfCircle(radius);

        Console.WriteLine($"Area of the circle with radius {radius}: {area}");
        Console.WriteLine($"Circumference of the circle with radius {radius}: {circumference}");
    }

    static double CalculateAreaOfCircle(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double CalculateCircumferenceOfCircle(double radius)
    {
        return 2 * Math.PI * radius;
    }
}
