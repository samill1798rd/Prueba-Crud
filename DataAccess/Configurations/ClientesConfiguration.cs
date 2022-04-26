using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.Configurations
{
    public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.HasKey(e => e.IdCliente)
                   .HasName("PK__Clientes__FCE039921AF207D1");

            builder.Property(e => e.IdCliente).HasColumnName("Id_cliente");

            builder.Property(e => e.Apellido)
                .HasColumnName("apellido")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Cedula)
                .HasColumnName("cedula")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FechaCreacion).HasColumnName("fechaCreacion");

            builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
