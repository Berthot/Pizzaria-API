using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Mapping
{
    public class OrderMapping
    {
        public OrderMapping(EntityTypeBuilder<Order> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_ORDER");
            entity.ToTable("Orders");

            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Nf)
                .HasMaxLength(350);
            
            entity.Property(x => x.Price)
                .IsRequired();

            entity.Property(x => x.PizzaFlavorId)
                .IsRequired();            
            
            entity.Property(x => x.ClientId)
                .IsRequired();
            
            entity.Property(x => x.PizzaTypeId)
                .IsRequired();

            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");

            entity.HasOne(x => x.PizzaFlavor)
                .WithMany(y => y.Orders)
                .HasForeignKey(z => z.PizzaFlavorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ORDER_PIZZAFLAVOR");
            
            entity.HasOne(x => x.Client)
                .WithMany(y => y.Orders)
                .HasForeignKey(z => z.ClientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ORDER_CLIENT");
            
            entity.HasOne(x => x.PizzaType)
                .WithMany(y => y.Orders)
                .HasForeignKey(z => z.PizzaTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ORDER_PIZZATYPE");


        }
    }
}