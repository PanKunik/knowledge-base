using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Truck : ITransport
    {
        // This class is instantiated with Factory. This class shares common interface with other classes, that belong to this family.
        public void DeliverPackage()
        {
            Console.WriteLine("Delivering package by the Truck.");
        }
    }
}
