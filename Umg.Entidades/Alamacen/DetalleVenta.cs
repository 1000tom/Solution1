using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.DetalleVenta
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public int descuento { get; set; }





    }
}
