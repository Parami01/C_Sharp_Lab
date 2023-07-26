using System;

class Program
{
    static void Main()
    {
        HelloWorld helloWorld = new HelloWorld();
        helloWorld.SayHello();
    }
}
//Question
//  Can you access the method? Explain why?
//Answer
/* 
    No,we can't.
    
    Private methods are encapsulated within the class and are not accessible from outside the class. 
    They are meant to be used only internally within the class itself. 
    This is an essential feature of encapsulation in object-oriented programming, 
    as it allows classes to hide implementation details and expose only 
    the necessary functionality to the outside world through public methods. 
*/
