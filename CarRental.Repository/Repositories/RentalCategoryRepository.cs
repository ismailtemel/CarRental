using CarRental.Core.Models;
using CarRental.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Repository.Repositories
{
    public class RentalCategoryRepository : GenericRepository<RentalCategory>, IRentalCategoryRepository
    {
        public RentalCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<RentalCategory> GetSingleRentalCategoryByIdWithCarAsync(int rentalCategoryId)
        {
            return await _context.RentalCategories.Include(x => x.Cars).Where(x => x.Id == rentalCategoryId).SingleOrDefaultAsync();
        }
    }
}
