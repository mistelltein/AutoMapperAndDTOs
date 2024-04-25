using AutoMapper;
using Web_API.DTOs;
using Web_API.Models;

namespace Web_API.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // source, destination
        CreateMap<RequestDTO, Book>().ReverseMap();

        CreateMap<Book, ResponseDTO>()
            .ForMember(dest => dest.TitleAndYear,
                opt => opt.MapFrom(src => $"{src.Title} {src.Year}"));
    }
}