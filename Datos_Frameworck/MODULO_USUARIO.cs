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
    
    public partial class MODULO_USUARIO
    {
        public int id { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_MODULO { get; set; }
        public Nullable<System.DateTime> FechaIncercion { get; set; }
    
        public virtual MODULOS MODULOS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
