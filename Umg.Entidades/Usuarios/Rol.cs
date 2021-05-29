using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Usuarios
{
    public class Rol
    {
        public int idRol { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string nombre { get; set; }
        [StringLength(256, MinimumLength = 150, ErrorMessage = "La descripcion debe tener un maximo de 20 carácteres")]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
