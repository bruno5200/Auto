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
    public class CD_Usuario
    {
        private CD_Conexion conection = new CD_Conexion();
        //private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public void AgregarUsuario(CE_User u)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "AgregarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", u.Nombre);
            comando.Parameters.AddWithValue("@cedula", u.Cedula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
    }
}
