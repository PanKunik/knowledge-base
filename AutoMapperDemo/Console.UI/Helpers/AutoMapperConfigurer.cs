using AutoMapper;
using Console.UI.DTO;
using Domain.Entities;

namespace Console.UI.Helpers
{
    public static class AutoMapperConfigurer
    {
        // Function that returns configured Mapper (can be also configured within DI container)
        public static IMapper MapperConfig()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                // This map maps property of type 'ProductType' to simple 'string' property
                // and maps ProductDTOs 'Code' property from 'Products' Id, Category name and Type name
                cfg.CreateMap<Product, ProductDTO>()
                   .ForMember(destination => destination.Type,
                              option => option.MapFrom(source => source.TypeOfProduct.Name))
                   .ForMember(destination => destination.Code,
                              options => options.MapFrom(source => source.Id + "/" + source.Category.Name + "/" + source.TypeOfProduct.Name));

                // Simple Map 1:1, ignoring Id from 'Category' in 'CategoryDTOs'
                cfg.CreateMap<Category, CategoryDTO>()
                   .ForMember(destination => destination.Id,
                   option => option.Ignore());
            });

            // This call tries to use all maps and checks if all propeties in destination object can be filled with data
            // If not it throws Exception of type 'AutoMapperConfigurationException' (to check uncomment 'Value' property in 'CategoryDTO')
            mapperConfig.AssertConfigurationIsValid();

            return mapperConfig.CreateMapper();
        }
    }
}
