using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Umg.Entidades.Articulo
{
   public class Articulo
    {
        public int idArticulo { get; set; }
        public int idCategoria { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El codigo debe tener un maximo de 50 carácteres")]
        public string codigo { get; set; }
        public string nombre { get; set; }
        [StringLength(50, MinimumLength = 30, ErrorMessage = "El Nombre debe tener un maximo de 50 carácteres")]
        public int precio { get; set; }
        public int stock { get; set; }
        public int condicion { get; set; }







    }
}
