using Domain.Common;
using System;

namespace Domain.Products.Victorian
{
    // Concrete product (B) of type IChair - Familly furniture
    public class VictorianChair : IChair
    {
        public int HowManyLegs()
        {
            Console.WriteLine("This chair has 4 legs. Legit!");
            return 4;
        }

        public void SitOn()
        {
            Console.WriteLine("You sit on Victorian XVIII's century chair. Do you feel like a Queen?");
        }
    }
}
