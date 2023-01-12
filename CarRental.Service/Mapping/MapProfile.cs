using AutoMapper;
using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //CreateMap<Car,CarDto>().ReverseMap();
            //CreateMap<RentalCategory,RentalCategoryDto>().ReverseMap();
        }
    }
}
