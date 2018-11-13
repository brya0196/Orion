using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Orion.Business;
using Orion.Data;
using Orion.Data.Models;

namespace Orion.Repository.Repository
{
    public class TiposUsuarioRepository : ITiposUsuario
    {
        private readonly OrionDbContext _dbContext;
        
        public TiposUsuarioRepository(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(TiposUsuario tiposUsuario)
        {
            var entry = _dbContext.Entry(tiposUsuario);
            if (entry.State == EntityState.Detached)
            {
                _dbContext.TiposUsuarios.Add(tiposUsuario);
            }
            else
            {
                entry.State = EntityState.Added;
            }
        }

        public void Update(TiposUsuario tiposUsuario)
        {
            var tipoUsuario = _dbContext.TiposUsuarios.SingleOrDefault(tp => tp.Id == tiposUsuario.Id);

            tipoUsuario.Nombre = tiposUsuario.Nombre;

            _dbContext.SaveChanges();
        }

        public void Delete(TiposUsuario tiposUsuario)
        {
            var entry = _dbContext.Entry(tiposUsuario);
            if (entry.State == EntityState.Detached)
            {
                _dbContext.TiposUsuarios.Remove(tiposUsuario);
            }
            else
            {
                entry.State = EntityState.Deleted;
            }
        }

        public IEnumerable<TiposUsuario> GetAll()
        {
            return _dbContext.TiposUsuarios.ToList();
        }

        public TiposUsuario GetById(int id)
        {
            return _dbContext.TiposUsuarios.Find(id);
        }
    }
}