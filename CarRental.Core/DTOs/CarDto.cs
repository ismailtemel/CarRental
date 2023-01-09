using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.DTOs
{
    public class CarDto 
    {
        public int Id { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int RentalDuration { get; set; }

        public DateTime RentalDate { get; set; }

        public decimal RentalPrice { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }
    }
}
