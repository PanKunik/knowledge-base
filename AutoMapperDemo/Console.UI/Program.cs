using System.Collections.Generic;
using Console.UI.DTO;
using Console.UI.Helpers;
using Console.UI.Helpers.Printers;
using Console.UI.Repositories;

namespace Console.UI
{
    class Program
    {

        static void Main(string[] args)
        {
            FakeRepository repository = new FakeRepository();

            var mapperConfig = AutoMapperConfigurer.MapperConfig();

            // Function that maps List<Product> -> List<ProductDTO> (note that you don't have to specifiy mapping from Source[] to Destination[] if you specified Source to Destination mapping).
            // ProductDTO does't have property of type ProductType. It has been mapped for simple string property.
            // ProductDTO have additional property 'Code' which is built using Products ID, Type and Category
            var productsDtos = mapperConfig.Map<List<ProductDTO>>(repository.Products);

            PrintProducts(productsDtos);

            System.Console.Read();
        }

        // Function that prints all properties of ProductDTO type
        static void PrintProducts(List<ProductDTO> products)
        {
            foreach (var product in products)
            {
                ProductPrinter.PrintProduct(product);
            }
        }
    }
}
