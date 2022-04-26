using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.Configurations
{
    public class ProductosConfiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.HasKey(e => e.IdProducto)
                .HasName("PK__Producto__1D8EFF017B00EC54");

            builder.Property(e => e.IdProducto).HasColumnName("Id_producto");

            builder.Property(e => e.Cantidad).HasColumnName("cantidad");

            builder.Property(e => e.FechaEntrada)
                .HasColumnName("fechaEntrada")
                .HasColumnType("date");

            builder.Property(e => e.NombreProducto)
                .HasColumnName("nombreProducto")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
