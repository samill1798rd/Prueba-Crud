using Model.Entities;
using System.Collections.Generic;

namespace Services.OrdenServices
{
    public interface IOrdenServices
    {
        IEnumerable<Orden> GetOrden();
        Orden GetOrdenById(int OrdenId);
        void InsertOrden(Orden orden);
        void UpdateOrden(Orden orden);
        void DeleteOrden(int OrdenId);
        void SaveChanges();
    }
}
