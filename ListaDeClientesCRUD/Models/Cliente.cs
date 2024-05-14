using System.ComponentModel.DataAnnotations;

namespace ListaDeClientesCRUD.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nombre { get; set;}
        [Required]
        public string Apellido { get; set;}
        [Required]
        public int Dni { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public int Telefono { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
