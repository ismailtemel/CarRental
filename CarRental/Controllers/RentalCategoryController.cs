using CarRental.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    public class RentalCategoryController : CustomBaseController
    {
        private readonly IRentalCategoryService _rentalCategoryService;

        public RentalCategoryController(IRentalCategoryService rentalCategoryService)
        {
            _rentalCategoryService = rentalCategoryService;
        }

        [HttpGet("[action]/{rentalCategoryId}")]
        public async Task<IActionResult> GetSingleRentalCategoryByWithCar(int rentalCategoryId)
        {
            return CreateActionResult(await _rentalCategoryService.GetSingleRentalCategoryByIdWithProductAsync(rentalCategoryId));
        }
    }
}
