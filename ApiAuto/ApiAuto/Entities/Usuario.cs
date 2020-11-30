using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Usuario
    {
        [Key]
        public long usuario_id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string cedula { get; set; }
    }
}