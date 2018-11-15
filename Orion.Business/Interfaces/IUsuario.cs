using System.Collections;
using Orion.Data.Models;

namespace Orion.Business
{
    public interface IUsuario
    {
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        IEnumerable<Usuario> GetAll();
        Usuario GetById(int id);
    }
}