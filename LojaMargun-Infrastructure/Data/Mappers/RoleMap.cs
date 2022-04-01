using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaMargun_Infrastructure.Data.Mappers
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(value => value.Name).HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(value => value.Description).HasColumnType("VARCHAR(100)").IsRequired().HasMaxLength(100);
            builder.ToTable("Role");
        }
    }
}
