using AutoMapper;
using CarRental.Core.DTOs;
using CarRental.Core.Models;
using CarRental.Core.Repositories;
using CarRental.Core.Services;
using CarRental.Core.UnitOfWork;

namespace CarRental.Service.Service
{
    public class RentalCategoryService : Service<RentalCategory>, IRentalCategoryService
    {
        private readonly IRentalCategoryRepository _rentalCategoryRepository;
        private readonly IMapper _mapper;

        public RentalCategoryService(IGenericRepository<RentalCategory> repository, IUnitOfWork unitOfWork, IMapper mapper, IRentalCategoryRepository rentalCategoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _rentalCategoryRepository = rentalCategoryRepository;
        }

        public async Task<CustomResponseDto<RentalCategoryWithCarDto>> GetSingleRentalCategoryByIdWithProductAsync(int rentalCategoryId)
        {
            var rentalcategory = await _rentalCategoryRepository.GetSingleRentalCategoryByIdWithCarAsync(rentalCategoryId);

            var rentalCategoryDto = _mapper.Map<RentalCategoryWithCarDto>(rentalcategory);

            return CustomResponseDto<RentalCategoryWithCarDto>.Success(200, rentalCategoryDto);
        }
    }
}
