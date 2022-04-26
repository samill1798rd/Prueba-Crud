using DataAccess.Data;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.OrdenServices
{
    public class OrdenServices : IOrdenServices
    {

        private SistemaVentasContext _dbConxtext;

        public OrdenServices(SistemaVentasContext dbConxtext)
        {
            _dbConxtext = dbConxtext;
        }

        public void DeleteOrden(int OrdenId)
        {
            var ordenObj = _dbConxtext.Orden.Find(OrdenId);
            _dbConxtext.Orden.Remove(ordenObj);
        }

        public IEnumerable<Orden> GetOrden()
        {
            return _dbConxtext.Orden.ToList();
        }

        public Orden GetOrdenById(int OrdenId)
        {
            return _dbConxtext.Orden.Find(OrdenId);
        }

        public void InsertOrden(Orden orden)
        {
            _dbConxtext.Orden.Add(orden);
        }

        public void SaveChanges()
        {
            _dbConxtext.SaveChanges();
        }

        public void UpdateOrden(Orden orden)
        {
            throw new NotImplementedException();
        }
    }
}
