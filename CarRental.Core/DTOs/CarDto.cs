namespace CarRental.Core.DTOs
{
    public class CarDto
    {
        public int Id { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int RentalDuration { get; set; }

        public decimal RentalPrice { get; set; }

        public int RentalCategoryId { get; set; }
    }
}
