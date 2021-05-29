using System.Collections.Generic;
using Umg.Entidades.Almacen;
using Umg.Entidades.Usuarios;

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

        public List<Persona> Personas { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Comprobante> Comprobantes { get; set; }
        public List<EstadoVenta> EstadosVenta { get; set; }

    }
}
