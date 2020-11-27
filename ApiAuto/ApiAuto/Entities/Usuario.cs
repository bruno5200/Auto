using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Entities
{
    public class Usuario
    {
        [Key]
        public long usuario_id { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
    }
}