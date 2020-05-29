using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class Submenu
    {
        public int Id { get; set; }
        public string SubMenuNombre { get; set; }
        public string SubMenuSys { get; set; }
        public int IdSubmodulo { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual Submodulos IdSubmoduloNavigation { get; set; }
    }
}
