using System.Collections.Generic;
using Umg.Entidades.Almacen;

namespace Umg.Entidades.Compras
{
    public class DetalleIngreso
    {
        public int idDetalleIngreso { get; set; }
        
        public int cantidad { get; set; }
        public int total { get; set; }

        public List<Ingreso> Ingresos { get; set; }
        public List<Articulo> Articulos { get; set; }
        
    }
}
