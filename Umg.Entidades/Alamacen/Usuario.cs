using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Usuario
{
    class Usuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        [StringLength( 20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres" )]
        public string PrimerNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres")]
        public string SegundoNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string PrimerApellido { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string SegundoApellido { get; set; }
        public int idDocumento { get; set; }
        public string direccion { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El telefono debe tener un maximo de 20 carácteres")]
        public string telefono { get; set; }
        [StringLength(50, MinimumLength = 20, ErrorMessage = "El email debe tener un maximo de 20 carácteres")]
        public string email { get; set; }
        public bool passwordHash { get; set; }
        public bool passwordSal { get; set; }
        public byte condicion { get; set; }
    }
}
