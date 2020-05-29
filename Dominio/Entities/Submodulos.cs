using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class Submodulos
    {
        public Submodulos()
        {
            Submenu = new HashSet<Submenu>();
        }

        public int Id { get; set; }
        public string NombreSubmod { get; set; }
        public string SysNom { get; set; }
        public int IdModulo { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual ICollection<Submenu> Submenu { get; set; }
    }
}
