using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    public class TipoPersona
    {
        public int idTipoPersona { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string nombre { get; set;  }
    }
}
