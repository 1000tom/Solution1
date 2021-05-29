using System.Collections.Generic;
using Umg.Entidades.Almacen;

namespace Umg.Entidades.Ventas
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public decimal descuento { get; set; }

        public List<Venta> Ventas { get; set; }
        public List<Articulo> Articulos { get; set; }
    }
}
