using System.ComponentModel.DataAnnotations;

namespace CRUDNet7MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Telefono es Obligatorio")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El Celular es Obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio")]
        public String  Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

