using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Auto
    {
        [Key]
        public long auto_id { get; set; }
        [Required]
        public string placa { get; set; }
        [Required]
        public string dir { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
    }
}