namespace CarRental.Core.DTOs
{
    public class RentalCategoryWithCarDto : RentalCategoryDto
    {
        public List<CarDto>? Cars { get; set; }
    }
}
