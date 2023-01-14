namespace CarRental.Core.DTOs
{
    public class CarWithRentalCategoryDto : CarDto
    {
        public RentalCategoryDto? RentalCategory { get; set; }
    }
}
