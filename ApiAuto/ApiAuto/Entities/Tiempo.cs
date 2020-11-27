using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Tiempo
    {
        [Key]
        public long tiempo_id { get; set; }
        public long usuario_id { get; set; }
        public long auto_id { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public bool estado { get; set; }
    }
}