using System.Collections.Generic;
using Orion.Data.Models;

namespace Orion.Business
{
    public interface IProductos
    {
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(Producto producto);
        IEnumerable<Producto> GetAll();
        Producto GetById(int id);
    }
}