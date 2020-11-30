using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Tiempo
    {
        [Key]
        public long tiempo_id { get; set; }
        [Required]
        public long usuario_id { get; set; }
        [Required]
        public long auto_id { get; set; }
        [Required]
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        [Required]
        public bool estado { get; set; }
    }
}