using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class ModuloUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
