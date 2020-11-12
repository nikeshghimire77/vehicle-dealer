using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.ToTable("Makes");
            builder.Property(mk => mk.Name).IsRequired();
            builder.Property(mk => mk.Name).IsRequired().HasMaxLength(255);

        }
    }
}