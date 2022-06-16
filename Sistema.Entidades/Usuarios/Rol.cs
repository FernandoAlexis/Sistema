using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Rol
    {
        [Required]
        public int idrol { get; set; }
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener mas de 30 caracteres ni menos de de 3 caracteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Usuario> usuarios { get; set; }
    }
}
