using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.ListaProductosOrdenServices
{
    public class ListaProductoOrdenServices : IListaProductoOrdenServices
    {
        private SistemaVentasContext _dbConxtext;

        public ListaProductoOrdenServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        public async Task<ListaProductoByOrden> AddProductosOrdenes(ListaProductoByOrden listaProducto)
        {
            var result = await _dbConxtext.ListaProductoByOrden.AddAsync(listaProducto);
            await _dbConxtext.SaveChangesAsync();

            return result.Entity;
        }

        public Task DeleteProductosOrdenesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ListaProductoByOrden>> GetListaProductosOrdenesList()
        {
            return await _dbConxtext.ListaProductoByOrden.ToListAsync();
        }

        public async Task<ListaProductoByOrden> GetProductosOrdenes(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ListaProductoByOrden> UpdateProductosOrdenes(ListaProductoByOrden listaProducto)
        {
            throw new NotImplementedException();
        }
    }
}
