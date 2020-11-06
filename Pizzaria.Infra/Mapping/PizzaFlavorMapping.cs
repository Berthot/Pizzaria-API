using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Mapping
{
    public class PizzaFlavorMapping
    {
        public PizzaFlavorMapping(EntityTypeBuilder<PizzaFlavor> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_PIZZA_FLAVOR");
            entity.ToTable("PizzaFlavor");
            
            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            entity.Property(x => x.OrderId)
                .IsRequired();
            
            entity.Property(x => x.FlavorId)
                .IsRequired();
            
            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");
            

            
            entity.HasOne(x => x.Order)
                .WithMany(y => y.PizzaFlavors)
                .HasForeignKey(z => z.OrderId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_PIZZAFLAVOR_ORDER");
            
                        
            entity.HasOne(x => x.Flavor)
                .WithMany(y => y.PizzaFlavors)
                .HasForeignKey(z => z.FlavorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_PIZZAFLAVOR_FLAVOR");
            
        }

    }
}