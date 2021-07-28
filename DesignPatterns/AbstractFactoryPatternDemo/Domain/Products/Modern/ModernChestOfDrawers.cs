using Domain.Common;
using System;

namespace Domain.Products.Modern
{
    // Concrete product (A) of type IChestOfDrawers - Familly furniture
    public class ModernChestOfDrawers : IChestOfDrawers
    {
        public double VolumeCapacity()
        {
            Console.WriteLine("This chest of drawers has very small volume capacity. It`s made out of paper.");
            return 1.5d;
        }
    }
}
