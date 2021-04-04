using AutoMapper;
using Console.UI.DTO;
using Domain.Entities;

namespace Console.UI.Helpers
{
    public class MappingProfile : Profile
    { 
        public MappingProfile()
        {
            // This map maps property of type 'ProductType' to simple 'string' property
            // and maps ProductDTOs 'Code' property from 'Products' Id, Category name and Type name
            CreateMap<Product, ProductDTO>().ForMember(destination => destination.Type, options => options.MapFrom(source => source.Name))
                                            .ForMember(destination => destination.Code, options => options.MapFrom(source => $"{ source.Id }/{ source.Category }/{ source.TypeOfProduct }"));

            // Simple Map 1:1, ignoring Id from 'Category' in 'CategoryDTOs'
            CreateMap<Category, CategoryDTO>().ForMember(destination => destination.Id, options => options.Ignore());
        }
    }
}
