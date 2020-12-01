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
        public void GuardarUsuario(CE_User u)
        {
           UserCD.AgregarUsuario(u);
        }
    }
}
