namespace Orion.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public TiposUsuario TipoUsuario { get; set; }
    }
}