using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Cls_Credito_Datos
    {
        public void Fnt_Guardar(
            String id,
            String dia_pago,
            String valor_prestamo,
            int plazo,
            String cuota,
            int interes,
            String valor_total,
            String user)
        {
            ClsConexion objconect_insert = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_NuevoCredito", objconect_insert.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@dia_pago", dia_pago);
            con.Parameters.AddWithValue("@valor_prestamo", valor_prestamo);
            con.Parameters.AddWithValue("@plazo", plazo);
            con.Parameters.AddWithValue("@cuota", cuota);
            con.Parameters.AddWithValue("@interes", interes);
            con.Parameters.AddWithValue("@valor_total", valor_total);
            con.Parameters.AddWithValue("@user", user);
            objconect_insert.connection.Open();
            con.ExecuteNonQuery();
            objconect_insert.connection.Close();
        }
    }
}
