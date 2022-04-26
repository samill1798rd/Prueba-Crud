using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClienteServices
{
    public class ClienteServices : IClienteServices
    {
        private SistemaVentasContext _dbConxtext;

        public ClienteServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        public async Task<Clientes> AddCliente(Clientes cliente)
        {
            var result = await _dbConxtext.Clientes.AddAsync(cliente);
            await _dbConxtext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task DeleteClienteAsync(int clientesId)
        {

            var result = await GetCliente(clientesId);

            if (result != null)
            {
                _dbConxtext.Clientes.Remove(result);
                await _dbConxtext.SaveChangesAsync();
            }


        }

        public async Task<Clientes> GetCliente(int clientesId)
        {
            return await _dbConxtext.Clientes
                 .FirstOrDefaultAsync(e => e.IdCliente == clientesId);
        }

        public async Task<IEnumerable<Clientes>> GetClientesList()
        {
            return await _dbConxtext.Clientes.ToListAsync();
        }

        public async Task<Clientes> UpdateCliente(Clientes cliente)
        {
            var result = await GetCliente(cliente.IdCliente);

            if (result != null)
            {
                result.IdCliente = cliente.IdCliente;
                result.Nombre = cliente.Nombre;
                result.Cedula = cliente.Cedula;
                result.FechaCreacion = cliente.FechaCreacion;
                result.IsActive = cliente.IsActive;


                await _dbConxtext.SaveChangesAsync();

                return result;
            }

            return null;

        }


    }
}
