using System;
using Orion.Business;
using Orion.Data;

namespace Orion.Repository.Generics
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _dbContext;
        
        public UnitOfWork(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public ITiposUsuario TiposUsuarios { get; private set; }
    }
}