using CarRental.Core.DTOs;
using CarRental.Core.Models;

namespace CarRental.Core.Services
{
    public interface IRentalCategoryService : IService<RentalCategory>
    {
        public Task<CustomResponseDto<RentalCategoryWithCarDto>> GetSingleRentalCategoryByIdWithProductAsync(int rentalCategoryId);
    }
}
