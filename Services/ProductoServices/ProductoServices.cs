using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductoServices
{
    public class ProductoServices : IProductoServices
    {

        private SistemaVentasContext _dbConxtext;

        public ProductoServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        public async Task<Productos> AddProductos(Productos productos)
        {
            var result = await _dbConxtext.Productos.AddAsync(productos);
            await _dbConxtext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task DeleteProductosAsync(int productosId)
        {
            var result = await GetProductos(productosId);

            if (result != null)
            {
                _dbConxtext.Productos.Remove(result);
                await _dbConxtext.SaveChangesAsync();
            }
        }

        public async Task<Productos> GetProductos(int productosId)
        {
            return await _dbConxtext.Productos
                  .FirstOrDefaultAsync(e => e.IdProducto == productosId);
        }

        public async Task<IEnumerable<Productos>> GetProductosList()
        {
            return await _dbConxtext.Productos.ToListAsync();
        }

        public async Task<Productos> UpdateProductos(Productos productos)
        {

            var result = await GetProductos(productos.IdProducto);

            if (result != null)
            {
                result.IdProducto = productos.IdProducto;
                result.NombreProducto = productos.NombreProducto;
                result.FechaEntrada = productos.FechaEntrada;
                result.Cantidad = productos.Cantidad;
                result.IsActive = productos.IsActive;


                await _dbConxtext.SaveChangesAsync();

                return result;
            }

            return null;

        }
    }
}
