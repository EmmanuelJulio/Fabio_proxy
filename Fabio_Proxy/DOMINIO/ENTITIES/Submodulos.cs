using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class Submodulos : Entidad
    {
        public Submodulos()
        {
            Submenu = new HashSet<Submenu>();
        }

       
        public string NombreSubmod { get; set; }
        public string SysNom { get; set; }
        public int IdModulo { get; set; }
      

        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual ICollection<Submenu> Submenu { get; set; }
    }
}
