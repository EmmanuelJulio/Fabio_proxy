//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos_Frameworck
{
    using System;
    using System.Collections.Generic;
    
    public partial class TERMINOS_DICCIONARIOS
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int id_diccionario { get; set; }
        public string term_abr { get; set; }
        public Nullable<System.DateTime> FechaIncercion { get; set; }
    
        public virtual Diccionario Diccionario { get; set; }
    }
}
