using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");
            builder.Property(v => v.ContactName).IsRequired();
            builder.Property(v => v.ContactName).IsRequired().HasMaxLength(255);
            builder.Property(v => v.ContactPhone).IsRequired();
            builder.Property(v => v.ContactPhone).IsRequired().HasMaxLength(255);
            builder.Property(v => v.ContactEmail).IsRequired();
            builder.Property(v => v.ContactEmail).IsRequired().HasMaxLength(255);
        }
    }
}