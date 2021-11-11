using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio1
{
    public class Miconexion
    {
        public static SqlConnection ObtnerConexion()
        {
            SqlConnection Conn = new SqlConnection(Properties.Settings.Default.Conectar);
            Conn.Open();
            return Conn;
        }
    }
}
