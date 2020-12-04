using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Auto
    {
        private CD_Auto AutoCD = new CD_Auto();
        public void GuardarAuto(CE_Auto a)
        {
            if (a.Marca != null && a.Tipo != null && a.Color != null)
            {
                a.Marca = a.Marca.ToUpper();
                a.Tipo = a.Tipo.ToUpper();
                a.Color = a.Color.ToUpper();
                AutoCD.ActualizarAuto(a);
            }
        }
        public DataTable ListarArchivos(DataTable archivo)
        {
            archivo = AutoCD.ListArchive(archivo);
            return archivo;
        }
        public DataTable ListarActivos(DataTable activos)
        {
            activos = AutoCD.ListActive(activos);
            return activos;
        }
        public DataTable ObtenerAuto(DataTable auto)
        {
            auto = AutoCD.ObtenerAuto(auto);
            return auto;
        }
    }
}