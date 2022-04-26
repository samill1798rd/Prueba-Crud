using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.Configurations
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.HasKey(e => e.IdOrden)
                    .HasName("PK__Orden__33F95B58EB84E4E1");

            builder.Property(e => e.IdOrden).HasColumnName("Id_orden");

            builder.Property(e => e.FechaCreacion).HasColumnName("fechaCreacion");

            builder.Property(e => e.OrdenName)
                .HasColumnName("ordenName")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
