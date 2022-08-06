using Authentication.Example.Entities;

namespace Authentication.Example.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    void AddProduct(Product product);
}