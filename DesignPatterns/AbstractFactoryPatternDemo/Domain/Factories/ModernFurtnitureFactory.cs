using Domain.Common;
using Domain.Products.Modern;

namespace Domain.Factories
{
    // Modern Abstract Factory - Subclass of a Base FurnitureFactory
    // This factory creates Modern furnitures of a familly 'Furniture'
    // This factory takes care about creating concrete products
    public class ModernFurtnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override IChestOfDrawers CreateChestOfDrawers()
        {
            return new ModernChestOfDrawers();
        }

        public override ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
