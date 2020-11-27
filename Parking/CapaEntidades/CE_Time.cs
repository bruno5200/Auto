using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Time
    {
        private long _id;
        private long _usuarioId;
        private long _autoId;
        private DateTime _inicio;
        private DateTime _fin;
        private bool _estado;

        public long Id { get => _id; set => _id = value; }
        public long UsuarioId { get => _usuarioId; set => _usuarioId = value; }
        public long AutoId { get => _autoId; set => _autoId = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
