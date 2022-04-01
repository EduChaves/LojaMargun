using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(value => value.Active).HasColumnType("BIT").IsRequired();
            builder.ToTable("Product");
        }
    }
}
