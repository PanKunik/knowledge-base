using SingletonLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Singleton design pattern.");

            Singleton p1;
            Singleton p2;

            p1 = Singleton.GetInstance();
            p2 = Singleton.GetInstance();

            if(p1.Equals(p2))
            {
                Console.WriteLine("Both instances are equal.");
            }
            else
            {
                Console.WriteLine("Instances aren't equal.");
            }

            Console.WriteLine("End of program.");
            Console.Read();
        }
    }
}
