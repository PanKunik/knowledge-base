using Domain.Common;
using System;

namespace Domain.Products.Modern
{
    // Concrete product (A) of type ITable - Familly furniture
    public class ModernTable : ITable
    {
        public void PutSomethingOn()
        {
            Console.WriteLine("You put something on modern chair. Be careful!");
        }
    }
}
