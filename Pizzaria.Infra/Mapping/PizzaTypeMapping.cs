using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Mapping
{
    public class PizzaTypeMapping
    {
        public PizzaTypeMapping(EntityTypeBuilder<PizzaType> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_PIZZA_TYPE");
            entity.ToTable("PizzaType");
            
            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            entity.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            entity.Property(x => x.QtyPrice)
                .HasMaxLength(50)
                .IsRequired();
            
            entity.Property(x => x.QtyFlavors)
                .HasMaxLength(50)
                .IsRequired();
            
            entity.Property(x => x.UpdateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");
            
        }
    }
}