using System.ComponentModel.DataAnnotations;
namespace Umg.Entidades.Almacen
{
    public class TipoDocumento
    {
        public int idTipoDocumento { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string nombre { get; set; }

    }
}
