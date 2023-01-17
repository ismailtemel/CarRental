using CarRental.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repository.Configuration
{
    public class RentalCategoryConfiguration : IEntityTypeConfiguration<RentalCategory>
    {
        public void Configure(EntityTypeBuilder<RentalCategory> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
