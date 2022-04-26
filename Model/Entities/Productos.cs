using System;

namespace Model.Entities
{
    public partial class Productos
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public int? Cantidad { get; set; }
        public bool? IsActive { get; set; }
    }
}
