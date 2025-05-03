using System.ComponentModel.DataAnnotations;

namespace BibloitecaAPI.Entidades
{
    public class Autor
    {
        public int ID { get; set; }
        [Required]
        public required string Nombre { get; set; }
    }
}
