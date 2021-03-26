using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsLogin_Datos
    {
        public String nombre;
        public int sw = 0;
        public void Fnt_ConsultarDB(String user, String pass)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Ingresar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Correo", user);
            con.Parameters.AddWithValue("@Clave", pass);
            objconect.connection.Open(); // Abre la conexion con el servidor de Base de datos
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                nombre = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            objconect.connection.Close();// Cierra la conexion con la Base de datos
        }
        
    }
}
