using Domain.Common;
using System;

namespace Domain.Products.Victorian
{
    // Concrete product (B) of type IChestOfDrawers - Familly furniture
    public class VictorianChestOfDrawers : IChestOfDrawers
    {
        public double VolumeCapacity()
        {
            Console.WriteLine("This chest of drawers is veeeery huge.");
            return 5.3d;
        }
    }
}
