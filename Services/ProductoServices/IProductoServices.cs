using Model.Entities;
using System.Collections.Generic;

namespace Services.ProductoServices
{
    public interface IProductoServices
    {
        IEnumerable<Productos> GetProducto();
        Productos GetProductoById(int ProductoId);
        void InsertProducto(Productos Producto);
        void UpdateProducto(Productos Producto);
        void DeleteProducto(int ProductoId);
        void SaveChanges();
    }
}
