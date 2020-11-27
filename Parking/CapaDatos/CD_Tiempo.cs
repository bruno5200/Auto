using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Tiempo
    {
        private CD_Conexion conection = new CD_Conexion();
        //private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public void AgregarTiempo(CE_Time t)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AgregarTiempo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario_id", t.UsuarioId);
            comando.Parameters.AddWithValue("@auto_id", t.AutoId); 
            comando.Parameters.AddWithValue("@inicio", t.Inicio);
            comando.Parameters.AddWithValue("@fin", t.Fin); 
            comando.Parameters.AddWithValue("@estado", t.Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}