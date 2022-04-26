namespace Model.Entities
{
    public partial class Orden
    {
        public int IdOrden { get; set; }
        public string OrdenName { get; set; }
        public int? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }
    }
}
