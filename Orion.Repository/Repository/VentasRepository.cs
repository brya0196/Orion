using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Orion.Business;
using Orion.Data;
using Orion.Data.Models;

namespace Orion.Repository.Repository
{
    public class VentasRepository : IVentas
    {
        private OrionDbContext _dbContext;

        public VentasRepository(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Venta venta)
        {
            var entry = _dbContext.Entry(venta);
            if (entry.State == EntityState.Detached)
            {
                var producto = _dbContext.Productos.Find(venta.ProductoId);
                producto.CantidadStock = producto.CantidadStock - 1;
                _dbContext.SaveChanges();
                
                _dbContext.Ventas.Add(venta);
            }
            else
            {
                entry.State = EntityState.Added;
            }
        }

        public IEnumerable<Venta> GetAll()
        {
            return _dbContext.Ventas
                .Include(V => V.Producto)
                .Include(V => V.Vendedor)
                .ToList();
        }

        public Venta GetById(int id)
        {
            return _dbContext.Ventas.Find(id);
        }
    }
}