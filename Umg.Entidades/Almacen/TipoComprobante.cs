using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Almacen
{
    public class TipoComprobante
    {
        public int idTipoComprobante { get; set; }
        [StringLength(50, MinimumLength = 10, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string Nombre { get; set; }

    }
}
