using LojaMargun_Domain.Entities;
using LojaMargun_Infrastructure.Data.Mappers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LojaMargun_Infrastructure.Data
{
    public class Context : IdentityDbContext<User, Role, string>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public Context(DbContextOptions<Context> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ClientMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new BagMap());
            builder.ApplyConfiguration(new SaleMap());
            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new AddressMap());
            builder.ApplyConfiguration(new ProductMap());

           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.LogTo(Console.WriteLine);
    }
}