using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(value => value.Name).HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(value => value.Length).HasColumnType("VARCHAR(15)").IsRequired().HasMaxLength(15);
            builder.Property(value => value.Active).HasColumnType("INTEGER(2)").IsRequired();
            builder.ToTable("Product");
        }
    }
}
