using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Infra.Mapping;

namespace Pizzaria.Infra
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }
        
        public DbSet<Client> Client { get; set; }
        public DbSet<Flavor> Flavor { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PizzaFlavor> PizzaFlavor { get; set; }
        public DbSet<PizzaType> PizzaType { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            new ClientMapping(builder.Entity<Client>());
            new FlavorMapping(builder.Entity<Flavor>());
            new OrderMapping(builder.Entity<Order>());
            new PizzaFlavorMapping(builder.Entity<PizzaFlavor>());
            new PizzaTypeMapping(builder.Entity<PizzaType>());
            base.OnModelCreating(builder);
        }
        
    }
}