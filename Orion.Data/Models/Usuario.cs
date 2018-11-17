using System;
using System.Collections.Generic;

namespace Orion.Data.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> TipoUsuarioId { get; set; }
        
        public virtual TiposUsuario TipoUsuario { get; set; }
    }
}