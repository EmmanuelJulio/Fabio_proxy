using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class Diccionario
    {
        public Diccionario()
        {
            TerminosDiccionarios = new HashSet<TerminosDiccionarios>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DicAbr { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual ICollection<TerminosDiccionarios> TerminosDiccionarios { get; set; }
    }
}
