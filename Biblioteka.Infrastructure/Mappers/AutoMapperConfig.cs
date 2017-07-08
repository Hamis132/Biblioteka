using AutoMapper;
using Biblioteka.Core.Domain;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            =>  new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User,UserDto>();
                cfg.CreateMap<Author,AuthorDto>();
                cfg.CreateMap<Book,BookDto>();
                cfg.CreateMap<Hire,HireDto>();
            }).CreateMapper();
        
    }
}