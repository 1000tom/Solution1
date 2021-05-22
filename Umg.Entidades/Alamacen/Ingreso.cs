using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ingreso
{
    public class Ingreso
    {
        public int idIngreso { get; set; }
        public int idProveedor { get; set; }
        public int idUsuario { get; set; }
        public int fechaHora { get; set; }
        public int impuesto { get; set; }
        public int total { get; set; }
        public int idEstadoIngreso { get; set; }

    }
}
