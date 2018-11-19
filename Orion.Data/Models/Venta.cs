namespace Orion.Data.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public int ProductoId { get; set; }
        public string Comprador { get; set; }
        
        public virtual Usuario Vendedor { get; set; }
        public virtual Producto Producto { get; set; }
    }
}