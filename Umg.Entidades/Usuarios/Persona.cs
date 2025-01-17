﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Umg.Entidades.Almacen;

namespace Umg.Entidades.Usuarios
{
    public class Persona
    {
        public int idPersona { get; set; }
        
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres")]
        public string primerNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 20 carácteres")]
        public string segundoNombre { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string primerApellido { get; set; }
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El Apellido debe tener un maximo de 20 carácteres")]
        public string segundoApellido { get; set; }
       
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public List<TipoPersona> TipoPersonas { get; set; }

        public List<Documento> Documentos { get; set; }



    }
}
