using AutoMapper;
using CarRental.Core.DTOs;
using CarRental.Core.Models;

namespace CarRental.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<RentalCategory, RentalCategoryDto>().ReverseMap();
            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarWithRentalCategoryDto>();
            CreateMap<RentalCategory, RentalCategoryWithCarDto>();
        }
    }
}
