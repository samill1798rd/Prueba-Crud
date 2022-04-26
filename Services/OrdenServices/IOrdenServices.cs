using Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.OrdenServices
{
    public interface IOrdenServices
    {
        Task<IEnumerable<Orden>> GetOrdenList();
        Task<Orden> GetOrden(int ordensId);
        Task<Orden> AddOrden(Orden orden);
        Task<Orden> UpdateOrden(Orden orden);
        Task DeleteOrdenAsync(int ordenId);
    }
}
