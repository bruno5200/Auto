using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Tiempo
    {
        CD_Tiempo TimeCD = new CD_Tiempo();
        CD_Local LocalCD = new CD_Local();
        public void GuardarTiempo(CE_Time t)
        {
            t = LocalCD.LoadData(t);
            t.UsuarioId += 1; t.AutoId += 1;
            LocalCD.SaveData(t);
            t.Inicio = DateTime.Now;
            t.Estado = true;
            TimeCD.AgregarTiempo(t);
        }
    }
}