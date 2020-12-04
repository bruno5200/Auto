using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Auto
    {
        private CD_Conexion conection = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public void ActualizarAuto(CE_Auto a)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ActualizarAuto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@auto_id", a.Id);
            comando.Parameters.AddWithValue("@placa", a.Placa);
            comando.Parameters.AddWithValue("@dir", a.Dir);
            comando.Parameters.AddWithValue("@marca", a.Marca);
            comando.Parameters.AddWithValue("@tipo", a.Tipo); 
            comando.Parameters.AddWithValue("@color", a.Color);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
        }
        public DataTable ListarAutosParqueados(DataTable activos)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarActivos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            activos.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return activos;
        }
        public DataTable ListArchive(DataTable archivo)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarArchivo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            archivo.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return archivo;
        }
        public DataTable ListActive(DataTable archivo)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ListarActivos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            archivo.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return archivo;
        }
        public DataTable ObtenerAuto(DataTable auto)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ObtenerAuto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            auto.Load(leer);
            leer.Close();
            conection.CerrarConexion();
            return auto;
        }
    }
}