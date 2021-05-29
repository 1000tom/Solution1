using System.Collections.Generic;

namespace Umg.Entidades.Almacen
{
    public class Documento
    {
        public int idDocumento { get; set; }
        
        public string numero { get; set; }

        public List<TipoDocumento> TipoDocumento { get; set; }

    }
}
