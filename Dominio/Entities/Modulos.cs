using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class Modulos
    {
        public Modulos()
        {
            ModuloUsuario = new HashSet<ModuloUsuario>();
            Submodulos = new HashSet<Submodulos>();
        }

        public int Id { get; set; }
        public string NombreMod { get; set; }
        public string CodMod { get; set; }
        public int SectorMod { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual ICollection<ModuloUsuario> ModuloUsuario { get; set; }
        public virtual ICollection<Submodulos> Submodulos { get; set; }
    }
}
