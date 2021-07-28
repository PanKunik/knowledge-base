using Domain.Common;
using System;

namespace Domain.Products.Victorian
{
    // Concrete product (B) of type ITable - Familly furniture
    public class VictorianTable : ITable
    {
        public void PutSomethingOn()
        {
            Console.WriteLine("You put something on XVIII's century Victorian table. Be careful!");
        }
    }
}
