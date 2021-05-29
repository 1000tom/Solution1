using System.Collections.Generic;
using Umg.Entidades.Almacen;
using Umg.Entidades.Usuarios;

namespace Umg.Entidades.Compras
{
    public class Ingreso
    {
        public int idIngreso { get; set; }
        public int idProveedor { get; set; }
        public int fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        

        public List<Persona> Personas { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Comprobante> Comprobantes { get; set; }
        public List<EstadoIngreso> EstadosIngresos { get; set; }
    }
}
