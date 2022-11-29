using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Configuarations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>();
            //CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>();
        
        }
    }
}
