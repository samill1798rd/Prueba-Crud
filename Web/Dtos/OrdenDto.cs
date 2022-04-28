namespace ApiProject.Dtos
{
    public class OrdenDto
    {
        public int IdOrden { get; set; }
        public string OrdenName { get; set; }
        public int? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }
    }
}
