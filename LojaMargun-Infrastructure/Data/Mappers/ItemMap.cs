using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(value => value.Name).HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(value => value.Description).HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(value => value.Length).HasColumnType("VARCHAR(20)").IsRequired().HasMaxLength(20);
            builder.Property(value => value.Image).IsRequired();
            builder.Property(value => value.Value).HasColumnType("NUMERIC(38,2)").IsRequired();
        }
    }
}
