using System.ComponentModel.DataAnnotations;

namespace CarRental.Core.Models
{
    public class RentalCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
