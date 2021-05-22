using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.DetalleIngreso
{
   public class DetalleIngreso
    {
        public int idDetalleIngreso { get; set; }
        public int idIngreso { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }




    }
}
