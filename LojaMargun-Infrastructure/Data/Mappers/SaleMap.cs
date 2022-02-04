using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.Property(value => value.BuyDate).HasColumnType("DATETIME").IsRequired();
            builder.Property(value => value.AddressEndNumber).HasColumnType("VARCHAR(150)").HasMaxLength(150).IsRequired();
            builder.Property(value => value.City).HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(value => value.State).HasColumnType("VARCHAR(2)").HasMaxLength(2).IsRequired();
            builder.Property(value => value.Cep).HasColumnType("VARCHAR(8)").HasMaxLength(8).IsRequired();
            builder.Property(value => value.Complement).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(value => value.TotalValue).HasColumnType("NUMERIC(38,2)").IsRequired();
            builder.ToTable("Sale");
        }
    }
}
