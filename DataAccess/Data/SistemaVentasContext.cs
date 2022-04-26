using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace DataAccess.Data
{
    public partial class SistemaVentasContext : DbContext
    {
        public SistemaVentasContext()
        {
        }

        public SistemaVentasContext(DbContextOptions<SistemaVentasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ListaProductoByOrden> ListaProductoByOrden { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientesConfiguration());
            modelBuilder.ApplyConfiguration(new ListaProductoByOrdenConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenConfiguration());
            modelBuilder.ApplyConfiguration(new ProductosConfiguration());
        }
    }
}
