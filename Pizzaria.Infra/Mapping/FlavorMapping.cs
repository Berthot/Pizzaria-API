using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Mapping
{
    public class FlavorMapping
    {
        public FlavorMapping(EntityTypeBuilder<Flavor> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_FLAVOR");
            entity.ToTable("Flavor");
            
            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
            
            entity.Property(x => x.Description)
                .HasMaxLength(200);

            entity.Property(x => x.Price)
                .IsRequired();

            entity.Property(x => x.Available)
                .HasDefaultValue(true);
        
            entity.Property(x => x.UpdateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");
                
            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");

        }
    }
}