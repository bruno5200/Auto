using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuto.Entities
{
    public class Auto
    {
        [Key]
        public int auto_id { get; set; }
        public string placa { get; set; }
        public string dir { get; set; }
    }
}