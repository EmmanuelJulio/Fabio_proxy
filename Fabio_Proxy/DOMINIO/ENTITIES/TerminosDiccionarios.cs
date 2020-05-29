using System;
using System.Collections.Generic;

namespace DOMINIO.ENTITIES
{
    public partial class TerminosDiccionarios : Entidad
    {
        
        public string Nombre { get; set; }
        public int IdDiccionario { get; set; }
        public string TermAbr { get; set; }
       
        public virtual Diccionario IdDiccionarioNavigation { get; set; }
    }
}
