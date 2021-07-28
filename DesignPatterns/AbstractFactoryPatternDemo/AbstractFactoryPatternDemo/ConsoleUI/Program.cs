using Domain.Common;
using Domain.Factories;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Factory is used to create various objects that are in the same familly.
            // Factories are taking care of creating these objects.
            // Factories are build by extending super class and overwritting methods.

            // Instantiating factory with 'Modern furniture factory'.
            // With this factory we can create all types of furniture in 'Modern' style.
            FurnitureFactory factory = new ModernFurtnitureFactory();

            // Using this factory we create furniture in the same style.
            IChair chair = factory.CreateChair();
            ITable table = factory.CreateTable();
            IChestOfDrawers chestOfDrawers = factory.CreateChestOfDrawers();

            chair.SitOn();
            chair.HowManyLegs();

            table.PutSomethingOn();

            chestOfDrawers.VolumeCapacity();
        }
    }
}
