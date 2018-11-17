using System;
using Orion.Business;
using Orion.Data;
using Orion.Repository.Repository;

namespace Orion.Repository.Generics
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _dbContext;
        
        public UnitOfWork(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
            
            TiposUsuarios = new TiposUsuarioRepository(_dbContext);
            Usuarios = new UsuariosRepository(_dbContext);
        }
        
        public ITiposUsuario TiposUsuarios { get; private set; }
        public IUsuario Usuarios { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
    }
}