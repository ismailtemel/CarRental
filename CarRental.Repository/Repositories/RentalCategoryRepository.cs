using CarRental.Core.Models;
using CarRental.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repository.Repositories
{
    public class RentalCategoryRepository : GenericRepository<RentalCategory>, IRentalCategoryRepository
    {
        public RentalCategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
