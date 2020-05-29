using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class Usuarios : Entidad
    {
        public Usuarios()
        {
            ModuloUsuario = new HashSet<ModuloUsuario>();
        }

       
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Sector { get; set; }
        public string Acceso { get; set; }
        public bool Activo { get; set; }
      
        public byte[] Email { get; set; }
        public string Legajo { get; set; }

        public virtual ICollection<ModuloUsuario> ModuloUsuario { get; set; }
    }
}
