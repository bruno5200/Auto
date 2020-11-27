using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario UserCD = new CD_Usuario();
        public CE_Time GuardarUsuario(CE_User u, CE_Time t)
        {
           t = UserCD.AgregarUsuario(u,t);
            return t;
        }
    }
}
