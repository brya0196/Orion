using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Orion.Business;
using Orion.Data;
using Orion.Data.Models;

namespace Orion.Repository.Repository
{
    public class ProductosRepository : IProductos
    {
        private OrionDbContext _dbContext;

        public ProductosRepository(OrionDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Producto producto)
        {
            var entry = _dbContext.Entry(producto);
            if (entry.State == EntityState.Detached)
            {
                var codigoProducto = (_dbContext.Productos.ToList().Count > 0) ? _dbContext.Productos.Last().CodigoProducto + 1 : 1;
                    
                producto.CodigoProducto = codigoProducto;
                _dbContext.Productos.Add(producto);
            }
            else
            {
                entry.State = EntityState.Added;
            }
        }

        public void Update(Producto producto)
        {
            var selectedProducto = _dbContext.Productos.SingleOrDefault(p => p.Id == producto.Id);

            selectedProducto.Nombre = producto.Nombre;
            selectedProducto.Precio = producto.Precio;
            selectedProducto.CantidadStock = producto.CantidadStock;
            selectedProducto.CantidadStock = producto.CantidadStock;
            selectedProducto.FechaVencimiento = producto.FechaVencimiento;
            
            _dbContext.SaveChanges();
        }

        public void Delete(Producto producto)
        {
            var entry = _dbContext.Entry(producto);
            if (entry.State == EntityState.Detached)
            {
                var productoRemover = _dbContext.Productos.Find(producto.Id);
                _dbContext.Productos.Remove(productoRemover);
            }
            else
            {
                entry.State = EntityState.Deleted;
            }
        }

        public IEnumerable<Producto> GetAll()
        {
            return _dbContext.Productos.ToList();
        }

        public Producto GetById(int id)
        {
            return _dbContext.Productos.Find(id);
        }
    }
}