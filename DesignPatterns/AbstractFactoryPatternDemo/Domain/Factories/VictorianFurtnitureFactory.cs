using Domain.Common;
using Domain.Products.Victorian;

namespace Domain.Factories
{
    // Modern Abstract Factory - Subclass of a Base FurnitureFactory
    // This factory creates Victorian's furnitures of a familly 'Furniture'
    // This factory takes care about creating concrete products
    public class VictorianFurtnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }

        public override IChestOfDrawers CreateChestOfDrawers()
        {
            return new VictorianChestOfDrawers();
        }

        public override ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
