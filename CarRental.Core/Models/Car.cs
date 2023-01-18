using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Core.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int RentalDuration { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal RentalPrice { get; set; }

        public int RentalCategoryId { get; set; }

        public RentalCategory? RentalCategory { get; set; }
    }
}
