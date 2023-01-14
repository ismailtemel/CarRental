namespace CarRental.Core.DTOs
{
    public class CarUpdateDto
    {
        public int Id { get; set; }
        public int RentalDuration { get; set; }
        public decimal RentalPrice { get; set; }
        public int RentalCategoryId { get; set; }
    }
}
