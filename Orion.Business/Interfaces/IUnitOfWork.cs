using System;

namespace Orion.Business
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        ITiposUsuario TiposUsuarios { get; }
        IUsuario Usuarios { get; }
        IProductos Productos { get; }
        IVentas Ventas { get; }
    }
}