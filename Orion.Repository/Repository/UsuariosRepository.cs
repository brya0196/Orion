using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Orion.Business;
using Orion.Data;
using Orion.Data.Models;

namespace Orion.Repository.Repository
{
    public class UsuariosRepository : IUsuario
    {
        private readonly OrionDbContext _dbContext;
        public UsuariosRepository(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Usuario usuario)
        {
            var entry = _dbContext.Entry(usuario);
            if (entry.State == EntityState.Detached)
            {
                _dbContext.Usuarios.Add(usuario);
            }
            else
            {
                entry.State = EntityState.Added;
            }
        }

        public void Update(Usuario usuario)
        {
            var tipoUsuario = _dbContext.Usuarios.SingleOrDefault(tp => tp.Id == usuario.Id);

            tipoUsuario.Nombre = usuario.Nombre;
            tipoUsuario.Apellido = usuario.Apellido;
            tipoUsuario.Email = usuario.Email;
            tipoUsuario.Password = usuario.Password;
            tipoUsuario.TipoUsuarioId = usuario.TipoUsuarioId;

            _dbContext.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            var entry = _dbContext.Entry(usuario);
            if (entry.State == EntityState.Detached)
            {
                var user = _dbContext.Usuarios.Find(usuario.Id);
                _dbContext.Usuarios.Remove(user);
            }
            else
            {
                entry.State = EntityState.Deleted;
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _dbContext.Usuarios
                    .Include(u => u.TipoUsuario)
                    .ToList();
        }

        public Usuario GetById(int id)
        {
            return _dbContext.Usuarios.Find(id);
        }
    }
}