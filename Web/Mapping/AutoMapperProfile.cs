using Web.ViewModel;
using AutoMapper;
using Model.Entities;

namespace Web.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClientesDto, Clientes>();
            CreateMap<Clientes, ClientesDto>();

            CreateMap<ListaProductoByOrdenDto, ListaProductoByOrden>();
            CreateMap<ListaProductoByOrden, ListaProductoByOrdenDto>();


            CreateMap<OrdenDto, Orden>();
            CreateMap<Orden, OrdenDto>();

            CreateMap<Productos, ProductosDto>();
            CreateMap<ProductosDto, Productos>();

        }
    }
}
