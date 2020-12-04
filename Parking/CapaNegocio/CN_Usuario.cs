using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario UserCD = new CD_Usuario();
        public void GuardarUsuario(CE_User u)
        {
            if (u.Nombre != null && u.Cedula != null)
            {
                u.Nombre = u.Nombre.ToUpper();
                UserCD.AgregarUsuario(u);
            }
        }
    }
}
