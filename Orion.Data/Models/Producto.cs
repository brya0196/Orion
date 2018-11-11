using System;

namespace Orion.Data.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CodigoProducto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Precio { get; set; }
        public int CantidadStock { get; set; }
    }
}