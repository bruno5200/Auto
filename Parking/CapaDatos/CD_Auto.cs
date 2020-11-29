using System;
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

        public CE_Time ActualizarAuto(CE_Auto a, CE_Time t)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "ActualizarAuto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@auto_id", a.Id);
            comando.Parameters.AddWithValue("@placa", a.Placa);
            comando.Parameters.AddWithValue("@dr", a.Dir);
            comando.Parameters.AddWithValue("@marca", a.Marca);
            comando.Parameters.AddWithValue("@tipo", a.Tipo); 
            comando.Parameters.AddWithValue("@color", a.Color);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conection.CerrarConexion();
            t = ObtenerAuto(a, t);
            return t;
        }
        public CE_Time ObtenerAuto(CE_Auto a, CE_Time t)
        {
            comando.Connection = conection.AbrirConexion();
            comando.CommandText = "idAuto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@placa", a.Placa);
            var au = comando.ExecuteReader();
            foreach (DataRow item in au)
            {
                t.AutoId = Convert.ToInt64(item[0]);
            }
            comando.Parameters.Clear();
            conection.CerrarConexion();
            return t;
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