
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Make, MakeDto>().ReverseMap();
            CreateMap<Model, ModelDto>().ReverseMap();
        }
    }
}