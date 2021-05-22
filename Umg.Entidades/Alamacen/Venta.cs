using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public int idComprobante { get; set; }
        public int fechaHora { get; set; }
        public int idEstadoVenta { get; set; }

    }
}
