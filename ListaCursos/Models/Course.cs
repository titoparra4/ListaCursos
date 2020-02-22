using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "El numero maximo de caracteres permitodo es 500")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El Autor es requerido")]
        [Display(Name = "Autor")]
        public string Author { get; set; }

        [Url(ErrorMessage = "La direccion no es valida")]
        public string Uri { get; set; }
    }
}
