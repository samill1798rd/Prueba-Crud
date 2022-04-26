using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.ListaProductosOrdenServices
{
    public interface IListaProductoOrdenServices
    {
        Task<IEnumerable<ListaProductoByOrden>> GetListaProductosOrdenesList();
        Task<ListaProductoByOrden> GetProductosOrdenes(int Id);
        Task<ListaProductoByOrden> AddProductosOrdenes(ListaProductoByOrden listaProducto);
        Task<ListaProductoByOrden> UpdateProductosOrdenes(ListaProductoByOrden listaProducto);
        Task DeleteProductosOrdenesAsync(int id);
    }
}
