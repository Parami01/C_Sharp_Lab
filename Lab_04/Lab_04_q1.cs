using System;

class ConvertValues
{
    public void KilometerToMeter()
    {
        Console.Write("Enter the kilometer value: ");
        double kilometer = double.Parse(Console.ReadLine());
        double meter = kilometer * 1000;
        Console.WriteLine($"{kilometer} kilometer is equal to {meter} meters.");
    }

    public void KilometerToMeter(double kilometer)
    {
        double meter = kilometer * 1000;
        Console.WriteLine($"{kilometer} kilometer is equal to {meter} meters.");
    }

    public double ConvertToMeter(double kilometer)
    {
        return kilometer * 1000;
    }
}

class Program
{
    static void Main()
    {
        ConvertValues converter = new ConvertValues();        
        converter.KilometerToMeter();

        Console.Write("Enter the kilometer value: ");
        double kilometer = double.Parse(Console.ReadLine());
        converter.KilometerToMeter(kilometer);  

        Console.Write("Enter the kilometer value: ");
        kilometer = double.Parse(Console.ReadLine());
        double meter = converter.ConvertToMeter(kilometer);
        
        Console.WriteLine($"{kilometer} kilometer is equal to {meter} meters.");
    }
}
