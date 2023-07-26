using System;

class Animal
{
    public void Display()
    {
        Console.WriteLine("I am an Animal");
    }
}

class Dog : Animal
{
    public void DisplayDog()
    {
        Console.WriteLine("I have four legs");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Dog dog = new Dog();

        animal.Display(); // Output: I am an Animal
        dog.Display();    // Output: I am an Animal
        dog.DisplayDog(); // Output: I have four legs
    }
}
