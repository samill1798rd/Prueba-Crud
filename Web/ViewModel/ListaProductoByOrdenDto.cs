using Model.Entities;
using System;

namespace Web.ViewModel
{
    public class ListaProductoByOrdenDto
    {
        public int? OrdenId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }

        public  Clientes Cliente { get; set; }
        public  Orden Orden { get; set; }
    }
}
