using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(value => value.Active).HasColumnType("BIT").IsRequired();
            builder.ToTable("Item");
        }
    }
}
