using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Almacen
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El codigo debe tener un maximo de 50 carácteres")]
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public string nombre { get; set; }
        [StringLength(256, MinimumLength = 150, ErrorMessage = "La Descricion debe tener un maximo de 256 carácteres")]
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public bool condicion { get; set; }

        public List<Categoria> Categorias { get; set; }

    }
}
