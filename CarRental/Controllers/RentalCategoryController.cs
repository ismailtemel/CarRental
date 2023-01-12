using CarRental.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CarRental.API.Controllers
{
    public class RentalCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
