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
        public void GuardarTiempo(CE_Time t)
        {
            t.Inicio = DateTime.Now;
            t.Estado = true;
            TimeCD.AgregarTiempo(t);
        }
    }
}