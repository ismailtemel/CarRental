using CarRental.Core.Models;
using CarRental.Core.Repositories;

namespace CarRental.Repository.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context)
        {
        }
    }
}
