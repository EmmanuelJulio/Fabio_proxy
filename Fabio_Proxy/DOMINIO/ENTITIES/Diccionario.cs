using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class Diccionario : Entidad
    {
        public Diccionario()
        {
            TerminosDiccionarios = new HashSet<TerminosDiccionarios>();
        }

      
        public string Nombre { get; set; }
        public string DicAbr { get; set; }
       

        public virtual ICollection<TerminosDiccionarios> TerminosDiccionarios { get; set; }
    }
}
