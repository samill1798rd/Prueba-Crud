using Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.ProductoServices
{
    public interface IProductoServices
    {
        Task<IEnumerable<Productos>> GetProductosList();
        Task<Productos> GetProductos(int productosId);
        Task<Productos> AddProductos(Productos productos);
        Task<Productos> UpdateProductos(Productos productos);
        Task DeleteProductosAsync(int productosId);
      
    }
}
