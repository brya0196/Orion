namespace Orion.Data.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public Usuario Vendedor { get; set; }
        public Usuario Comprador { get; set; }
        public Producto Producto { get; set; }
    }
}