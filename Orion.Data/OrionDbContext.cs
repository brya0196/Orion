using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Orion.Data.Models;

namespace Orion.Data
{
    public class OrionDbContext : DbContext
    {
        public OrionDbContext(DbContextOptions<OrionDbContext> options)
            : base(options)
        {

        }

        public DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TiposUsuario>().HasKey(tp => tp.Id);
            modelBuilder.Entity<Producto>().HasKey(p => p.Id);
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Venta>().HasKey(v => v.Id);
        }
    }
}