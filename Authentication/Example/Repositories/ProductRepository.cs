using Authentication.Example.Entities;

namespace Authentication.Example.Repositories;

public class ProductRepository : IProductRepository
{
    private static List<Product> _products = new List<Product>()
    {
        new Product(1, "Mleko 3.2% UHT", 3.99m),
        new Product(2, "Pasta do zębów", 14.98m),
        new Product(3, "Chleb pszenny", 4.85m)
    };

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}