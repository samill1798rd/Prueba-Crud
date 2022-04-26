using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.OrdenServices
{
    public class OrdenServices : IOrdenServices
    {

        private SistemaVentasContext _dbConxtext;

        public OrdenServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        public async Task<Orden> AddOrden(Orden orden)
        {
            var result = await _dbConxtext.Orden.AddAsync(orden);
            await _dbConxtext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task DeleteOrdenAsync(int ordenId)
        {
            var result = await GetOrden(ordenId);

            if (result != null)
            {
                _dbConxtext.Orden.Remove(result);
                await _dbConxtext.SaveChangesAsync();
            }
        }

        public async Task<Orden> GetOrden(int ordensId)
        {
            return await _dbConxtext.Orden
                 .FirstOrDefaultAsync(e => e.IdOrden == ordensId);
        }

        public async Task<IEnumerable<Orden>> GetOrdenList()
        {
            return await _dbConxtext.Orden.ToListAsync();
        }

        public async Task<Orden> UpdateOrden(Orden orden)
        {
            var result = await GetOrden(orden.IdOrden);

            if (result != null)
            {
                result.IdOrden = orden.IdOrden;
                result.OrdenName = orden.OrdenName;
                result.FechaCreacion = orden.FechaCreacion;
                result.IsActive = orden.IsActive;


                await _dbConxtext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
