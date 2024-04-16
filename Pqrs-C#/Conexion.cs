using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pqrs_C_
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string server = "localhost";
            string database = "usuario";
            string user = "root";
            string password = "Osoted12.";
            string cadenaConexion;
            cadenaConexion = "Database=" + database + "; DataSource=" + server + "; User Id=" + user + "; Password=" + password;

            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
