using DataAccess.Data;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.ProductoServices
{
    public class ProductoServices : IProductoServices
    {

        private SistemaVentasContext _dbConxtext;

        public ProductoServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }
        public void DeleteProducto(int ProductoId)
        {
            var productoObj = _dbConxtext.Productos.Find(ProductoId);
            _dbConxtext.Productos.Remove(productoObj);
        }

        public IEnumerable<Productos> GetProducto()
        {
            return _dbConxtext.Productos.ToList();
        }

        public Productos GetProductoById(int ProductoId)
        {
            return _dbConxtext.Productos.Find(ProductoId);
        }

        public void InsertProducto(Productos Producto)
        {
            _dbConxtext.Productos.Add(Producto);
        }

        public void SaveChanges()
        {
            _dbConxtext.SaveChanges();
        }

        public void UpdateProducto(Productos Producto)
        {
            throw new NotImplementedException();
        }
    }
}
