using Domain.Common;
using System;

namespace Domain.Products.Modern
{
    // Concrete product (A) of type IChar - Familly furniture
    public class ModernChair : IChair
    {
        public int HowManyLegs()
        {
            Console.WriteLine("This chair has no legs.");
            return 0;
        }

        public void SitOn()
        {
            Console.WriteLine("You sit on modern chair.");
        }
    }
}
