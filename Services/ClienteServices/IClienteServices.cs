using Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.ClienteServices
{
    public interface IClienteServices
    {
        Task<IEnumerable<Clientes>> GetClientesList();
        Task<Clientes> GetCliente(int clientesId);
        Task<Clientes> AddCliente(Clientes cliente);
        Task<Clientes> UpdateCliente(Clientes cliente);
        Task DeleteClienteAsync(int clientesId);
    }
}
