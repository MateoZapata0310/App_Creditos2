using System;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R3AHI75\\SQLSERVER2020;Initial Catalog=DB_Creditos; integrated security = true");
    }
}
