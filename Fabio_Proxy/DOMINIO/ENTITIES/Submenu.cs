using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class Submenu : Entidad
    {
       
        public string SubMenuNombre { get; set; }
        public string SubMenuSys { get; set; }
        public int IdSubmodulo { get; set; }
       

        public virtual Submodulos IdSubmoduloNavigation { get; set; }
    }
}
