using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Persona
{
    public class Persona
    {
        public int idPersona { get; set; }
        public int idTipoPersona { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres")]
        public string primerNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres")]
        public string segundoNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string primerApellido { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string segundoApellido { get; set; }
        public int idDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }







    }
}
