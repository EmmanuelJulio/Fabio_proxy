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
    
    public partial class SUBMENU
    {
        public int id { get; set; }
        public string subMenu_nombre { get; set; }
        public string subMenu_Sys { get; set; }
        public int ID_SUBMODULO { get; set; }
        public Nullable<System.DateTime> FechaIncercion { get; set; }
    
        public virtual SUBMODULOS SUBMODULOS { get; set; }
    }
}
