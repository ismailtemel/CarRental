using System.ComponentModel.DataAnnotations;

namespace CarRental.Core.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int RentalDuration { get; set; }

        public DateTime RentalDate { get; set; }

        public decimal RentalPrice { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public int RentalCategoryId { get; set; }

        public RentalCategory RentalCategory { get; set; }
    }
}
