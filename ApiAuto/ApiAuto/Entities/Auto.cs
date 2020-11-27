using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Auto
    {
        [Key]
        public long auto_id { get; set; }
        public string placa { get; set; }
        public string dir { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
    }
}