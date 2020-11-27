using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Auto
    {
        private long _id;
        private string _placa;
        private string _dir;
        private string _tipo;
        private string _marca;
        private string _color;

        public long Id { get => _id; set => _id = value; }
        public string Placa { get => _placa; set => _placa = value; }
        public string Dir { get => _dir; set => _dir = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Color { get => _color; set => _color = value; }
    }
}