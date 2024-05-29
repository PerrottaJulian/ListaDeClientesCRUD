using System.ComponentModel.DataAnnotations;

namespace ListaDeClientesCRUD.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Telefono { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
