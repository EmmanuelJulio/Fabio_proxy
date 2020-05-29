using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class ModuloUsuario : Entidad
    {

        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }


        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
