using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.Property(value => value.SaleDate).HasColumnType("DATETIME").IsRequired();
            builder.Property(value => value.Payment).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(value => value.TotalValue).HasColumnType("NUMERIC(38,2)").IsRequired();
            builder.ToTable("Sale");
        }
    }
}
