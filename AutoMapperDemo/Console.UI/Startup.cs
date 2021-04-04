using AutoMapper;
using Console.UI.DTO;
using Console.UI.Helpers.Printers;
using Console.UI.Repositories;
using System.Collections.Generic;

namespace Console.UI
{
    public class Startup
    {
        private readonly IMapper _mapper;

        public Startup(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Run()
        {
            FakeRepository repository = new FakeRepository();

            // Function that maps List<Product> -> List<ProductDTO> (note that you don't have to specifiy mapping from Source[] to Destination[] if you specified Source to Destination mapping).
            // ProductDTO does't have property of type ProductType. It has been mapped for simple string property.
            // ProductDTO have additional property 'Code' which is built using Products ID, Type and Category

            /* Example with depencendy injection */
            var productsDtos = _mapper.Map<List<ProductDTO>>(repository.Products);
            /* Example with dependency injection */
            
            /* Example without Dependency Injection */
            // var mapper = AutoMapperConfigurer.MapperConfig();
            // var productsDtos = mapper.Map<List<ProductDTO>>(repository.Products);
            /* Without dependency injection */

            PrintProducts(productsDtos);

            System.Console.Read();
        }


        // Function that prints all properties of ProductDTO type
        void PrintProducts(List<ProductDTO> products)
        {
            foreach (var product in products)
            {
                ProductPrinter.PrintProduct(product);
            }
        }
    }
}
