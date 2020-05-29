using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class Modulos : Entidad
    {
        public Modulos()
        {
            ModuloUsuario = new HashSet<ModuloUsuario>();
            Submodulos = new HashSet<Submodulos>();
        }


        public string NombreMod { get; set; }
        public string CodMod { get; set; }
        public int SectorMod { get; set; }


        public virtual ICollection<ModuloUsuario> ModuloUsuario { get; set; }
        public virtual ICollection<Submodulos> Submodulos { get; set; }
    }
}
