using Domain.Factories;
using System;

namespace ConsoleUI
{
    class Program
    {
        // In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of
        // creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by
        // calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally
        // overridden by derived classes—rather than by calling a constructor. 
        static void Main(string[] args)
        {
            // Here we are creating instance of a 'AirLogistic' Factory class. We can change this to e.g. 'SeaLogistic' to use ships to deliver package.
            Logistics logistic = new AirLogistics();
            logistic.Deliver();
        }
    }
}
