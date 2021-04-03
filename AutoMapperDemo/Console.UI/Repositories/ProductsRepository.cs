using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.UI.Repositories
{
    public class FakeRepository
    {
        public List<Product> Products { get; } = new List<Product>();
        public List<Category> Categories { get; } = new List<Category>();
        public List<ProductType> ProductTypes { get; } = new List<ProductType>();

        public FakeRepository()
        {
            FillDummyData();
        }

        private void FillDummyData()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Name = "Dairy",
                Order = 1
            });

            Categories.Add(new Category()
            {
                Id = 2,
                MainCategory = 1,
                Name = "Milks",
                Order = 1
            });

            Categories.Add(new Category()
            {
                Id = 3,
                MainCategory = 1,
                Name = "Cheeses",
                Order = 0
            });

            ProductTypes.Add(new ProductType()
            {
                Id = 1,
                Name = "Groceries",
                Description = "",
                Order = 0
            });

            ProductTypes.Add(new ProductType()
            {
                Id = 2,
                Name = "Chemistry",
                Description = "",
                Order = 1
            });

            Products.Add(new Product()
            {
                Id = 1,
                Name = "Milk 2% UHT",
                Description = "A nice milk with medium fat content. Very delicious.",
                Category = Categories.Where(item => item.Name == "Milks")
                                     .FirstOrDefault(),
                TypeOfProduct = ProductTypes.Where(item => item.Name == "Groceries")
                                            .FirstOrDefault()
            });

            Products.Add(new Product()
            {
                Id = 2,
                Name = "Gouda Chees",
                Description = "Very yellow and fat gouda chees. Yummy!",
                Category = Categories.Where(item => item.Name == "Cheeses")
                                     .FirstOrDefault(),
                TypeOfProduct = ProductTypes.Where(item => item.Name == "Groceries")
                                            .FirstOrDefault()
            });
        }
    }
}
