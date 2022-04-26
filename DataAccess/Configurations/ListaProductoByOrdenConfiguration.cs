using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.Configurations
{
    public class ListaProductoByOrdenConfiguration : IEntityTypeConfiguration<ListaProductoByOrden>
    {
        public void Configure(EntityTypeBuilder<ListaProductoByOrden> builder)
        {
            builder.HasNoKey();

            builder.Property(e => e.ClienteId).HasColumnName("clienteId");

            builder.Property(e => e.FechaCreacion)
                .HasColumnName("fechaCreacion")
                .HasColumnType("date");

            builder.Property(e => e.OrdenId).HasColumnName("ordenId");

            builder.HasOne(d => d.Cliente)
                .WithMany()
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__ListaProd__clien__1920BF5C");

            builder.HasOne(d => d.Orden)
                .WithMany()
                .HasForeignKey(d => d.OrdenId)
                .HasConstraintName("FK__ListaProd__orden__182C9B23");
        }
    }
}
