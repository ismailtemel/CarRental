using CarRental.Core.Models;

namespace CarRental.Core.Repositories
{
    public interface IRentalCategoryRepository : IGenericRepository<RentalCategory>
    {
        Task<RentalCategory> GetSingleRentalCategoryByIdWithCarAsync(int rentalCategoryId);
    }
}
