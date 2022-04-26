using System;

namespace Model.Entities
{
    public partial class ListaProductoByOrden
    {
        public int? OrdenId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Orden Orden { get; set; }
    }
}
