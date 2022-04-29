using System;

namespace Web.ViewModel
{
    public class ProductosDto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public int? Cantidad { get; set; }
        public bool? IsActive { get; set; }
    }
}
