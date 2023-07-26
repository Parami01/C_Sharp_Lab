using System;

class FindValues
{
    public double FindArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public double FindCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        FindValues calculator = new FindValues();

        double area = calculator.FindArea(radius);
        double circumference = calculator.FindCircumference(radius);

        Console.WriteLine($"Area of the circle: {area}");
        Console.WriteLine($"Circumference of the circle: {circumference}");
    }
}
