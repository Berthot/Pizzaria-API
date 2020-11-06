using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Mapping
{
    public class ClientMapping
    {
        public ClientMapping(EntityTypeBuilder<Client> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_CLIENT");
            entity.ToTable("Client");
            
            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(x => x.Phone)
                .HasMaxLength(16)
                .IsRequired();

            entity.Property(x => x.Address)
                .HasMaxLength(90)
                .IsRequired();

            entity.Property(x => x.AddressNumber)
                .HasMaxLength(8)
                .IsRequired();

            entity.Property(x => x.IsApartment)
                .HasDefaultValue(false);

            entity.Property(x => x.ApartmentFloor)
                .HasDefaultValue(0);

            entity.Property(x => x.UpdateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");
            
            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");

        }
    }
}