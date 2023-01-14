using AutoMapper;
using CarRental.Core.DTOs;
using CarRental.Core.Models;
using CarRental.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    public class CarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICarService _carService;

        public CarController(IMapper mapper, ICarService carService)
        {
            _mapper = mapper;
            _carService = carService;
        }

        // GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var cars = await _carService.GetAllAsync();
            var carsDtos = _mapper.Map<List<CarDto>>(cars.ToList());
            return CreateActionResult(CustomResponseDto<List<CarDto>>.Success(200, carsDtos));
        }

        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        { 
            var car = await _carService.GetByIdAsync(id);
            var carDtos = _mapper.Map<CarDto>(car);
            return CreateActionResult(CustomResponseDto<CarDto>.Success(200, carDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CarDto carDto)
        {
            var cars = await _carService.AddAsync(_mapper.Map<Car>(carDto));
            var carDtos = _mapper.Map<CarDto>(cars);
            return CreateActionResult(CustomResponseDto<CarDto>.Success(201,carDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarUpdateDto carUpdateDto)
        {
            await _carService.UpdateAsync(_mapper.Map<Car>(carUpdateDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var cars = await _carService.GetByIdAsync(id);
            await _carService.RemoveAsync(cars);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
