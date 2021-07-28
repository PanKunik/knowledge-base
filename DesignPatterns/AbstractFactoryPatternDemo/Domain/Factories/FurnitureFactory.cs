using Domain.Common;

namespace Domain.Factories
{
    // Abstract Factory - Base factory used to extend by subclasses.
    // This is main 'interface' used in other concrete factories
    public abstract class FurnitureFactory
    {
        public abstract IChair CreateChair();
        public abstract ITable CreateTable();
        public abstract IChestOfDrawers CreateChestOfDrawers();
    }
}
