using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source =.; Initial Catalog =Parking;Integrated Security=True");
        public SqlConnection AbrirConexion()
        { //metodo para abrir la conexion si esta cerrada
            if (Conexion.State == ConnectionState.Closed)//comprobamos el estado de la conexion
                Conexion.Open();//abrimos la conexion si esta cerrada
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        { //metodo para cerrar la conexion si esta abierta

            if (Conexion.State == ConnectionState.Open)//comprobamos el estado de la conexion
                Conexion.Close();//cerrramos la conexion si esta abierta
            return Conexion;
        }
    }
}
