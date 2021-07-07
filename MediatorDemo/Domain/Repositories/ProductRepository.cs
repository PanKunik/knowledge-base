using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        // Returning dummy products data
        public async Task<IEnumerable<Product>> GetProducts(Func<Product, bool> predicate)
        {
            var products = new List<Product>() { new Product() { ID = 1, Name = "Mleko", Value = 3.29M },
                                         new Product() { ID = 2, Name = "Ser", Value = 5.99M }
            };

            return products.Where(predicate).ToList();
        }
    }

    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProducts(Func<Product, bool> predicate);
    }
}
