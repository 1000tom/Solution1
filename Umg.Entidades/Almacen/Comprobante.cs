using System.Collections.Generic;

namespace Umg.Entidades.Almacen
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        
        public string serie { get; set; }
        public string numero { get; set; }

        public List<TipoComprobante> TipoComprobantes { get; set; }
    }
}
