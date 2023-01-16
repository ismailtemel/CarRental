using AutoMapper;
using CarRental.Core.Models;
using CarRental.Core.Repositories;
using CarRental.Core.Services;
using CarRental.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Service.Service
{
    public class CarService : Service<Car> ,ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(IGenericRepository<Car> repository,IUnitOfWork unitOfWork,IMapper mapper,ICarRepository carRepository) : base(repository,unitOfWork)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }
    }
}
