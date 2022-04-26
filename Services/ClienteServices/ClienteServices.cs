using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.ClienteServices
{
    public class ClienteServices : IClienteServices
    {
        private SistemaVentasContext _dbConxtext;

        public ClienteServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        
        public void DeleteCliente(int ClienteId)
        {
            var clienteObj = _dbConxtext.Clientes.Find(ClienteId);
            _dbConxtext.Clientes.Remove(clienteObj);
        }

        public IEnumerable<Clientes> GetCliente()
        {
            return _dbConxtext.Clientes.ToList();
        }

        public Clientes GetClienteById(int ClienteId)
        {
            return _dbConxtext.Clientes.Find(ClienteId);
        }

        public void InsertCliente(Clientes cliente)
        {
            _dbConxtext.Clientes.Add(cliente);
        }

        public void SaveChanges()
        {
            _dbConxtext.SaveChanges();
        }

        public void UpdateCliente(Clientes cliente)
        {
            throw new NotImplementedException();
        }

  
    }
}
