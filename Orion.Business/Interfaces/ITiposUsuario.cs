using System.Collections.Generic;
using Orion.Data.Models;

namespace Orion.Business
{
    public interface ITiposUsuario
    {
        void Add(TiposUsuario tiposUsuario);
        void Update(TiposUsuario tiposUsuario);
        void Delete(TiposUsuario tiposUsuario);
        IEnumerable<TiposUsuario> GetAll();
        TiposUsuario GetById(int id);
    }
}