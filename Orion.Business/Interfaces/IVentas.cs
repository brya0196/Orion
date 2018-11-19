using System.Collections.Generic;
using Orion.Data.Models;

namespace Orion.Business
{
    public interface IVentas
    {
        void Add(Venta venta);
        IEnumerable<Venta> GetAll();
        Venta GetById(int id);
    }
}