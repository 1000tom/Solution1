using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }

        public bool condicion { get; set; }
    }
}
