using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Cls_Clientes_Datos
    {
        public SqlDataReader Lectura;
        public void Fnt_AgregarCliente(
        String id,
        String nombre,
        String contacto,
        String correo,
        String edad,
        String ingresos,
        String empresa,
        String contactoE,
        String sexo,
        String estadoCivil)
        {

            Fnt_Agregar(id, nombre, contacto, correo, edad, ingresos, empresa, contactoE, sexo, estadoCivil);

        }
        protected void Fnt_Agregar(String id,
        String nombre,
        String contacto,
        String correo,
        String edad,
        String ingreso,
        String empresa,
        String contactoE,
        String sexo,
        String estadoCivil)

        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@nombres", nombre);
            con.Parameters.AddWithValue("@contacto", contacto);
            con.Parameters.AddWithValue("@correo", correo);
            con.Parameters.AddWithValue("@edad", edad);
            con.Parameters.AddWithValue("@ingresos", ingreso);
            con.Parameters.AddWithValue("@empresa", empresa);
            con.Parameters.AddWithValue("@contactoE", contactoE);
            con.Parameters.AddWithValue("@sexo", sexo);
            con.Parameters.AddWithValue("@estado", estadoCivil);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        public void Fnt_ConsultarDatos(String id)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; 
            con = new SqlCommand("SP_BuscarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            objconect.connection.Open(); // Abre la conexion con el servidor de Base de datos
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                //nombre = Convert.ToString(Lectura[0]);
                //sw = 1;
            }
            //objconect.connection.Close();// Cierra la conexion con la Base de datos
        }
    }
}
