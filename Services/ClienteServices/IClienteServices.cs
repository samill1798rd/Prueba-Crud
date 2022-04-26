using Model.Entities;
using System.Collections.Generic;

namespace Services.ClienteServices
{
    public interface IClienteServices
    {
        IEnumerable<Clientes> GetCliente();
        Clientes GetClienteById(int ClienteId);
        void InsertCliente(Clientes cliente);
        void UpdateCliente(Clientes cliente);
        void DeleteCliente(int ClienteId);
        void SaveChanges();
    }
}
