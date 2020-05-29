using System;
using System.Collections.Generic;

namespace Dominio.Entities
{
    public partial class TerminosDiccionarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDiccionario { get; set; }
        public string TermAbr { get; set; }
        public DateTime? FechaIncercion { get; set; }

        public virtual Diccionario IdDiccionarioNavigation { get; set; }
    }
}
