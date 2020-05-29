using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.Entities
{
    public class Entidad
    {
        
        [Key]
      public int Id { get; set; }
      public DateTime FechaIncercion { get; set; }
    }
}
